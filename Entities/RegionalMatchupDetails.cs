using Google.Cloud.Firestore;

namespace BlazorApp.Entities;

[FirestoreData]
public class RegionalMatchupDetails
{
    public RegionalMatchupDetails() => RegionalMatchups = [];

    public RegionalMatchupDetails(string RegionalClass){
        this.RegionalClass = RegionalClass;
        this.RegionalMatchups = [];
    }
    
    public RegionalMatchupDetails(string RegionalClass, List<MatchupGroup> RegionalMatchups){
        this.RegionalClass = RegionalClass;
        this.RegionalMatchups = RegionalMatchups;
    }

    public RegionalMatchupDetails Clone() => new()
    {
        RegionalClass = RegionalClass,
        RegionalMatchups = RegionalMatchups
                .Select(kvp => new MatchupGroup
                {
                    Id = kvp.Id,
                    Matchup = kvp.Matchup.Clone()
                })
                .ToList()
    };

    [FirestoreProperty("RegionalClass")]
    public string RegionalClass {get;set;}
	[FirestoreProperty("RegionalMatchups")]
    public List<MatchupGroup> RegionalMatchups {get;set;}
}