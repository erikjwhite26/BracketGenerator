using BlazorApp.Entities;
namespace BlazorApp.Data;

public class HelperFunctions()
{

    public static Dictionary<int, object> ConvertBracket(List<RegionalMatchupGroup> regionalMatchupGroups)
    {
        try
        {
            var matchups = regionalMatchupGroups;
            var bracket = new Dictionary<int, object>();

            foreach (var region in matchups)
            {
                var regionDict = new Dictionary<string, object>
                {
                    ["RegionalClass"] = region.RegionalMatchupDetails.RegionalClass
                };

                var matchupsDict = new Dictionary<int, object>();

                foreach (var mg in region.RegionalMatchupDetails.RegionalMatchups)
                {
                    var matchupDict = new Dictionary<string, object>
                    {
                        [key: "MatchupClass"] = mg.Matchup.MatchupClass,
                        [key: "NextMatchup"] = mg.Matchup.NextMatchup,
                        [key: "NextMatchupTeam"] = mg.Matchup.NextMatchupTeam,
                        [key: "Regional"] = mg.Matchup.Regional
                    };

                    if (mg.Matchup.Team1 != null)
                    {
                        var team1Dict = new Dictionary<string, object>
                        {
                            [key: "Name"] = mg.Matchup.Team1.Name,
                            [key: "Seed"] = mg.Matchup.Team1.Seed
                        };
                        matchupDict[key: "Team1"] = team1Dict;
                    }
                    if (mg.Matchup.Team2 != null)
                    {
                        var team2Dict = new Dictionary<string, object>
                        {
                            [key: "Name"] = mg.Matchup.Team2.Name,
                            [key: "Seed"] = mg.Matchup.Team2.Seed
                        };
                        matchupDict[key: "Team2"] = team2Dict;
                    }
                    matchupsDict[mg.Id] = matchupDict;
                }

                regionDict["RegionalMatchups"] = matchupsDict;

                bracket[region.Id] = regionDict;
            }
            return bracket;
        }
        catch (Exception e)
        {
            Console.Write(e);
        }
        return [];
    }

    public static Dictionary<string, object> ConvertStats(List<StatDetails> statDetails)
    {
        var stats = new Dictionary<string, object>();

        foreach(var details in statDetails)
        {
            var statProbDict = new Dictionary<int, object>();

            foreach(var stat in details.Stats)
            {
                var probDict = new Dictionary<string, object>
                {
                    [key: "Probability"] = stat.Probability
                };
                statProbDict[stat.Id] = probDict;
            }

            stats[details.Id] = statProbDict;
        }
        return stats;
    }

    public static string GetFriendlyFirebaseAuthError(Exception ex)
    {
        var msg = ex.Message.ToUpperInvariant();
        Console.Write(msg);

        // LOGIN + REGISTER shared errors
        if (msg.Contains("INVALID-LOGIN-CREDENTIALS") ||
            msg.Contains("INVALID-PASSWORD"))
            return "The email or password you entered is incorrect.";

        if (msg.Contains("EMAIL-NOT-FOUND"))
            return "No account exists with that email address.";

        if (msg.Contains("USER-DISABLED"))
            return "This account has been disabled.";

        if (msg.Contains("TOO-MANY-ATTEMPTS"))
            return "Too many attempts. Please wait a moment and try again.";

        if (msg.Contains("MISSING-PASSWORD"))
            return "Please enter your password.";

        if (msg.Contains("MISSING-EMAIL"))
            return "Please enter your email address.";

        if (msg.Contains("INVALID-EMAIL"))
            return "Please enter a valid email address.";

        // REGISTER‑specific errors
        if (msg.Contains("EMAIL-EXISTS"))
            return "An account with this email already exists.";

        if (msg.Contains("WEAK-PASSWORD"))
            return "Your password is too weak. Try adding more characters or symbols.";

        if (msg.Contains("OPERATION-NOT-ALLOWED"))
            return "Email/password sign‑ups are disabled for this project.";

        // fallback
        return "Something went wrong. Please try again.";
    }
}