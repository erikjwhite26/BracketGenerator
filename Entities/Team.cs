using Google.Cloud.Firestore;

namespace BlazorApp.Entities;

[FirestoreData]
public class Team
{
    public Team Clone() => new()
    {
        Seed = Seed,
        Name = Name
    };

    [FirestoreProperty("Seed")]
	public int? Seed { get; set; }
	[FirestoreProperty("Name")]
	public string? Name { get; set; }
}