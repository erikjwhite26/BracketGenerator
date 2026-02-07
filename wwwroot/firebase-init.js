import { initializeApp } from "https://www.gstatic.com/firebasejs/10.8.1/firebase-app.js";
import { getAuth } from "https://www.gstatic.com/firebasejs/10.8.1/firebase-auth.js";
       
import {
  getFirestore,
  collection,
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
            for(const mKey in matchups.RegionalMatchups){						
                var tVal = matchups.RegionalMatchups[mKey];
                tourneyGroup.regionalMatchupGroups.find(t => t.id === parseInt(key)).regionalMatchupDetails.regionalMatchups.push(
                    {
                        id: parseInt(mKey), 
                        matchup: {
                            nextMatchup: parseInt(tVal.NextMatchup),
                            nextMatchupTeam: parseInt(tVal.NextMatchupTeam),
                            regional: parseInt(tVal.Regional),
                            matchupClass: tVal.MatchupClass,
                            team1: {seed: parseInt(tVal.Team1.Seed), name: tVal.Team1.Name},
                            team2: {seed: parseInt(tVal.Team2.Seed), name: tVal.Team2.Name}
                        }
                    }
                );
            }
        }
        console.log(tourneyGroup);
        return tourneyGroup;
    }
    return null;
}