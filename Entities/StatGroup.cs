namespace BlazorApp.Entities;
public class StatGroup{
    public StatGroup() => StatDetails = [];

    public StatGroup(string Id, List<StatDetails> StatDetails){
        this.Id = Id;
        this.StatDetails = StatDetails;
    }
    
    public string Id {get;set;}
    public List<StatDetails> StatDetails {get;set;}
}