namespace BlazorApp.Entities;
public class StatProbability
{
    public StatProbability(){}
    public StatProbability(int Id, dynamic Probability){
        this.Id = Id;
        this.Probability = Convert.ToDouble(Probability);
    }

    public int Id {get;set;}
    public double Probability {get;set;}
}