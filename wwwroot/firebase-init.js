import { initializeApp } from "https://www.gstatic.com/firebasejs/10.8.1/firebase-app.js";
import { getAuth } from "https://www.gstatic.com/firebasejs/10.8.1/firebase-auth.js";
       
import {
  getFirestore,
  collection,
  collectionGroup,
  addDoc,
  setDoc,
  getDoc,
  getDocs,
  doc
} from "https://www.gstatic.com/firebasejs/10.8.1/firebase-firestore.js";

const firebaseConfig = {
    apiKey: "AIzaSyBWhH38Smhy-tPTuFvA2BU7VnGVESM5-0k",
    authDomain: "bracketgenerator-497b2.firebaseapp.com",
    projectId: "bracketgenerator-497b2",
    storageBucket: "bracketgenerator-497b2.appspot.com",
    messagingSenderId: "132334408453",
    appId: "1:132334408453:web:a26bfc13125e4043b7dd6c"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);

// Initialize services
const auth = getAuth(app);
const db = getFirestore(app);

// Export the auth instance so firebase-auth.js can import it
export function initFirebase() {
    return auth;
}

// Also expose db globally if you need it
window.db = db;

// Define a function to add a new user to the Firestore database
window.addBracket = async (bracket, tourneyGroup) => {
  try {
    const docRef = await setDoc(doc(db, "officialBrackets/" + bracket), tourneyGroup);
  } catch (e) {
    console.error("Error adding bracket: ", e);
  }
};

window.addUserBracket = async (bracketId, bracketName, champion, bracket) => {
    try {
        const docRef = await setDoc(doc(db, "userBrackets", auth.currentUser.uid, "id", bracketId, "brackets", bracketName), {
            "Id": bracketName,
            "Champion": champion,
            "Bracket": bracket
        });
    }catch(e){
        console.error("Error adding user bracket: ", e);
    }
}

window.retrieveUserBrackets = async (bracketId) => {
    try {
        const uid = auth.currentUser?.uid;
        if (!uid) return [];

        const colRef = collection(db, "userBrackets", uid, "id", bracketId, "brackets");
        const snapshot = await getDocs(colRef);

        const brackets = [];

        snapshot.forEach(docSnap => {
            const data = docSnap.data();

            // Build the TourneyGroup object
            const tourneyGroup = {
                Id: data.Id,
                Champion: data.Champion,
                RegionalMatchupGroups: []
            };

            // Rebuild the bracket structure
            const bracketData = data.Bracket;

            for (const regionKey in bracketData) {
                const region = bracketData[regionKey];

                const regionObj = {
                    Id: parseInt(regionKey),
                    RegionalMatchupDetails: {
                        RegionalClass: region.RegionalClass,
                        RegionalMatchups: []
                    }
                };

                // Add matchups
                for (const matchupKey in region.RegionalMatchups) {
                    const m = region.RegionalMatchups[matchupKey];

                    regionObj.RegionalMatchupDetails.RegionalMatchups.push({
                        Id: parseInt(matchupKey),
                        Matchup: {
                            NextMatchup: m.NextMatchup,
                            NextMatchupTeam: m.NextMatchupTeam,
                            Regional: m.Regional,
                            Round: m.Round,
                            MatchupClass: m.MatchupClass,
                            Team1: {
                                Seed: m.Team1.Seed,
                                Name: m.Team1.Name
                            },
                            Team2: {
                                Seed: m.Team2.Seed,
                                Name: m.Team2.Name
                            }
                        }
                    });
                }

                tourneyGroup.RegionalMatchupGroups.push(regionObj);
            }

            brackets.push(tourneyGroup);
        });

        return brackets;

    } catch (e) {
        console.error("Error retrieving user brackets: ", e);
        return [];
    }
};

window.retrieveAllUserBrackets = async () => {
    try {
        const colRef = collectionGroup(db, "brackets");
        const snapshot = await getDocs(colRef);
        const allBrackets = [];

        snapshot.forEach(docSnap => {
            const data = docSnap.data();

            try {
                // Walk the parent chain:
                // userBrackets/{userId}/id/{MensBracket|WomensBracket}/brackets/{bracketId}
                const bracketsCollection = docSnap.ref.parent;        // .../brackets
                const genderDoc = bracketsCollection.parent;           // .../{MensBracket|WomensBracket}
                const idCollection = genderDoc?.parent;                // .../id
                const userDoc = idCollection?.parent;                  // .../{userId}
                const userId = userDoc?.id;
                const bracketType = genderDoc?.id;

                if (!userId || !bracketType) {
                    console.warn("[retrieveAllUserBrackets] Missing userId or bracketType, skipping doc:", docSnap.ref.path);
                    return;
                }

                const tourneyGroup = {
                    UserId: userId,
                    BracketType: bracketType,
                    Id: data.Id,
                    Champion: data.Champion,
                    RegionalMatchupGroups: []
                };

                const bracketData = data.Bracket;
                for (const regionKey in bracketData) {
                    const region = bracketData[regionKey];

                    const regionObj = {
                        Id: parseInt(regionKey),
                        RegionalMatchupDetails: {
                            RegionalClass: region.RegionalClass,
                            RegionalMatchups: []
                        }
                    };

                    for (const matchupKey in region.RegionalMatchups) {
                        const m = region.RegionalMatchups[matchupKey];

                        regionObj.RegionalMatchupDetails.RegionalMatchups.push({
                            Id: parseInt(matchupKey),
                            Matchup: {
                                NextMatchup: m.NextMatchup,
                                NextMatchupTeam: m.NextMatchupTeam,
                                Regional: m.Regional,
                                Round: m.Round,
                                MatchupClass: m.MatchupClass,
                                Team1: {
                                    Seed: m.Team1.Seed,
                                    Name: m.Team1.Name
                                },
                                Team2: {
                                    Seed: m.Team2.Seed,
                                    Name: m.Team2.Name
                                }
                            }
                        });
                    }
                    tourneyGroup.RegionalMatchupGroups.push(regionObj);
                }
                allBrackets.push(tourneyGroup);

            } catch (innerErr) {
                console.error("[retrieveAllUserBrackets] Error processing doc:", docSnap.ref.path, innerErr);
            }
        });
        return allBrackets;
    } catch (e) {
        console.error("[retrieveAllUserBrackets] Fatal error:", e);
        return [];
    }
};

window.addStats = async (stat, stats) => {
  try {
    const docRef = await setDoc(doc(db, "realStats/" + stat), stats);
  } catch (e) {
    console.error("Error adding bracket: ", e);
  }
};

window.retrieveStats = async (id, statGroup) => {
    const statsSnapshot = await getDoc(doc(db, "realStats/" + id));
    if(statsSnapshot.exists()){
        statGroup.id = id;
        for(const key in statsSnapshot.data()){
            statGroup.statDetails.push({
                id: key,
                stats: []
            });
            var probs = statsSnapshot.data()[key];
            for(const pKey in probs){
                statGroup.statDetails.find(s => s.id === key).stats.push({id: parseInt(pKey), probability: probs[pKey].Probability});
            }
        }
        return statGroup;
    }
    return null
}

window.retrieveBrackets = async (id, tourneyGroup) => {
    const tourneySnapshot = await getDoc(doc(db, "officialBrackets/" + id));
    if(tourneySnapshot.exists()){
        tourneyGroup.id = id;
        for(const key in tourneySnapshot.data()){
            var matchups = tourneySnapshot.data()[key];
            tourneyGroup.regionalMatchupGroups.push({
                id: parseInt(key),
                regionalMatchupDetails: {
                    regionalClass: matchups.RegionalClass, 
                    regionalMatchups: []
                }
            });
            for (const mKey in matchups.RegionalMatchups) {
                const tVal = matchups.RegionalMatchups[mKey];
                const m = parseInt(mKey);

                // Determine round based on mKey
                let round = 0;
                if (m < 33) round = 1;
                else if (m < 49) round = 2;
                else if (m < 57) round = 3;
                else if (m < 61) round = 4;
                else if (m < 63) round = 5;
                else if (m === 63) round = 6;

                tourneyGroup.regionalMatchupGroups
                    .find(t => t.id === parseInt(key))
                    .regionalMatchupDetails
                    .regionalMatchups
                    .push({
                        id: m,
                        matchup: {
                            nextMatchup: parseInt(tVal.NextMatchup),
                            nextMatchupTeam: parseInt(tVal.NextMatchupTeam),
                            regional: parseInt(tVal.Regional),
                            round: round,
                            matchupClass: tVal.MatchupClass,
                            team1: {
                                seed: parseInt(tVal.Team1.Seed),
                                name: tVal.Team1.Name
                            },
                            team2: {
                                seed: parseInt(tVal.Team2.Seed),
                                name: tVal.Team2.Name
                            }
                        }
                    });
            }
        }
        return tourneyGroup;
    }
    return null;
}