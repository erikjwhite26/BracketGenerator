using BlazorApp.Entities;
using Google.Cloud.Firestore; 

namespace BlazorApp.Data;

[FirestoreData]
public class RegionalMatchup
{
	[FirestoreProperty("RegionalClass")]
	public string RegionalClass { get; set; }
	[FirestoreProperty("RegionalMatchups")]
	public Dictionary<int, Matchup> RegionalMatchups { get; set; }
}