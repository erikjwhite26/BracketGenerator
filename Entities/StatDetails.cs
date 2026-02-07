namespace BlazorApp.Entities;
public class StatDetails
{
    public StatDetails() => Stats = [];

    public StatDetails(string Id){
        this.Id = Id;
        this.Stats = [];
    }
    
    public StatDetails(string Id, List<StatProbability> Stats){
        this.Id = Id;
        this.Stats = Stats;
    }

    public string Id {get;set;}
    public List<StatProbability> Stats {get;set;}
}