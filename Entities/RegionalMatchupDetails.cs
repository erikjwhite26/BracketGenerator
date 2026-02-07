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

	[FirestoreProperty("RegionalClass")]
    public string RegionalClass {get;set;}
	[FirestoreProperty("RegionalMatchups")]
    public List<MatchupGroup> RegionalMatchups {get;set;}
}