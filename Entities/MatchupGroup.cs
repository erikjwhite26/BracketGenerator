using Google.Cloud.Firestore;

namespace BlazorApp.Entities;

[FirestoreData]
public class MatchupGroup
{
    public MatchupGroup()
    {
        Matchup = new Matchup();
    }

    public MatchupGroup(int Id)
    {
        this.Id = Id;
        Matchup = new Matchup();
    }

    public MatchupGroup(int Id, Matchup Matchups)
    {
        this.Id = Id;
        Matchup = Matchups;
    }

    [FirestoreProperty("Id")]
    public int Id { get; set; }
    [FirestoreProperty("Matchup")]
    public Matchup Matchup { get; set; }
}