using Google.Cloud.Firestore;

namespace BlazorApp.Entities;

[FirestoreData]
public class RegionalMatchupGroup{
    public RegionalMatchupGroup(){
        RegionalMatchupDetails = new RegionalMatchupDetails();
    }

    public RegionalMatchupGroup(int Id, RegionalMatchupDetails RegionalMatchupDetails){
        this.Id = Id;
        this.RegionalMatchupDetails = RegionalMatchupDetails;
    }
    
	[FirestoreProperty("Id")]
    public int Id {get;set;}
	[FirestoreProperty("RegionalMatchupDetails")]
    public RegionalMatchupDetails RegionalMatchupDetails {get;set;}
}