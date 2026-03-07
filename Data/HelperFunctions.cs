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
                        [key: "Regional"] = mg.Matchup.Regional,
                        [key: "Round"] = mg.Matchup.Round
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

    public static int GetBracketPoints(List<RegionalMatchupGroup> officialBracket, TourneyGroup bracket)
	{
		int correct = 0;

		foreach (var region in bracket.RegionalMatchupGroups)
		{
			var officialRegion = officialBracket.FirstOrDefault(r => r.Id == region.Id);
			if (officialRegion == null) continue;

			foreach (var matchup in region.RegionalMatchupDetails.RegionalMatchups)
			{
				if(matchup.Matchup.Round == 1) continue;

				var officialMatchup = officialRegion.RegionalMatchupDetails.RegionalMatchups
					.FirstOrDefault(m => m.Id == matchup.Id);

				if (officialMatchup == null) continue;

				// Skip if official winner is missing
				var officialWinner1 = officialMatchup.Matchup.Team1.Name;
				if (string.IsNullOrWhiteSpace(officialWinner1))
					continue;

				// Determine user's winner
				var userWinner1 = matchup.Matchup.Team1.Name;

				if (!string.IsNullOrWhiteSpace(userWinner1) &&
					userWinner1.Equals(officialWinner1, StringComparison.OrdinalIgnoreCase))
				{
					correct+=100*(matchup.Matchup.Round - 1);
				}

				// Skip if official winner is missing
				var officialWinner2 = officialMatchup.Matchup.Team2.Name;
				if (string.IsNullOrWhiteSpace(officialWinner2))
					continue;

				// Determine user's winner
				var userWinner2 = matchup.Matchup.Team2.Name;

				if (!string.IsNullOrWhiteSpace(userWinner2) &&
					userWinner2.Equals(officialWinner2, StringComparison.OrdinalIgnoreCase))
				{
					correct+=100*(matchup.Matchup.Round - 1);
				}
			}
		}
		return correct;
	}
}