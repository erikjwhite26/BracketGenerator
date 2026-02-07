using Google.Cloud.Firestore;

namespace BlazorApp.Entities;

[FirestoreData]
public class Team
{
	[FirestoreProperty("Seed")]
	public int? Seed { get; set; }
	[FirestoreProperty("Name")]
	public string? Name { get; set; }
}