namespace BlazorApp.Entities;
public class TourneyGroup : IEquatable<TourneyGroup>{
    public TourneyGroup() => RegionalMatchupGroups = [];

    public TourneyGroup(string Id, List<RegionalMatchupGroup> RegionalMatchupGroups){
        this.Id = Id;
        this.RegionalMatchupGroups = RegionalMatchupGroups;
    }
    
    public string Id {get;set;}
    public string? BracketType {get;set;}
    public string? UserId {get;set;}
    public string Champion {get;set;}
    public List<RegionalMatchupGroup> RegionalMatchupGroups {get;set;}

    public bool Equals(TourneyGroup? other)
    {
        if (other is null) return false;
        return string.Equals(Id, other.Id, StringComparison.Ordinal);
    }

    public override bool Equals(object? obj) =>
        obj is TourneyGroup tg && Equals(tg);

    public override int GetHashCode() =>
        Id?.GetHashCode() ?? 0;

    public static bool operator ==(TourneyGroup? left, TourneyGroup? right) =>
        Equals(left, right);

    public static bool operator !=(TourneyGroup? left, TourneyGroup? right) =>
        !Equals(left, right);
}