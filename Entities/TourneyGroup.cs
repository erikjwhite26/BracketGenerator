namespace BlazorApp.Entities;
public class TourneyGroup{
    public TourneyGroup() => RegionalMatchupGroups = [];

    public TourneyGroup(string Id, List<RegionalMatchupGroup> RegionalMatchupGroups){
        this.Id = Id;
        this.RegionalMatchupGroups = RegionalMatchupGroups;
    }
    
    public string Id {get;set;}
    public List<RegionalMatchupGroup> RegionalMatchupGroups {get;set;}
}