using Google.Cloud.Firestore;

namespace BlazorApp.Entities;

[FirestoreData]
public class Matchup
{
    [FirestoreProperty("NextMatchup")]
    public int NextMatchup { get; set; }
    [FirestoreProperty("NextMatchupTeam")]
    public int NextMatchupTeam { get; set; }
    [FirestoreProperty("Regional")]
    public int Regional { get; set; }
    [FirestoreProperty("MatchupClass")]
    public string MatchupClass { get; set; }
    [FirestoreProperty("Team1")]
    public Team Team1 { get; set; }
    [FirestoreProperty("Team2")]
    public Team Team2 { get; set; }
}