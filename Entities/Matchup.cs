using Google.Cloud.Firestore;

namespace BlazorApp.Entities;

[FirestoreData]
public class Matchup
{
    public Matchup Clone() => new()
    {
        NextMatchup = NextMatchup,
        NextMatchupTeam = NextMatchupTeam,
        Regional = Regional,
        Round = Round,
        MatchupClass = MatchupClass,
        Team1 = Team1.Clone(),
        Team2 = Team2.Clone()
    };

    [FirestoreProperty("NextMatchup")]
    public int NextMatchup { get; set; }
    [FirestoreProperty("NextMatchupTeam")]
    public int NextMatchupTeam { get; set; }
    [FirestoreProperty("Regional")]
    public int Regional { get; set; }
    [FirestoreProperty("Round")]
    public int Round { get; set; }
    [FirestoreProperty("MatchupClass")]
    public string MatchupClass { get; set; }
    [FirestoreProperty("Team1")]
    public Team Team1 { get; set; }
    [FirestoreProperty("Team2")]
    public Team Team2 { get; set; }
}