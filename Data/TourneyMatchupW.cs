using BlazorApp.Entities;

namespace BlazorApp.Data;
public class TourneyMatchupW
{
    public List<RegionalMatchupGroup> Matchups { get; set; }

    public TourneyMatchupW()
    {
        Matchups =
        [
            BuildRegion1(),
            BuildRegion2(),
            BuildRegion3(),
            BuildRegion4(),
            BuildFinalFour()
        ];
    }

    private RegionalMatchupGroup BuildRegion1()
    {
        return new RegionalMatchupGroup(
            1,
            new RegionalMatchupDetails(
                "region-1",
                new List<MatchupGroup>
                {
                    new MatchupGroup(1, new Matchup
                    {
                        NextMatchup = 33,
                        NextMatchupTeam = 1,
                        Regional = 1,
                        MatchupClass = "matchup-1",
                        Team1 = new Team { Seed = 1, Name = "South Carolina" },
                        Team2 = new Team { Seed = 16, Name = "Norfolk St" }
                    }),
                    new MatchupGroup(2, new Matchup
                    {
                        NextMatchup = 33,
                        NextMatchupTeam = 2,
                        Regional = 1,
                        MatchupClass = "matchup-2",
                        Team1 = new Team { Seed = 8, Name = "South Florida" },
                        Team2 = new Team { Seed = 9, Name = "Marquette" }
                    }),
                    new MatchupGroup(3, new Matchup
                    {
                        NextMatchup = 34,
                        NextMatchupTeam = 1,
                        Regional = 1,
                        MatchupClass = "matchup-3",
                        Team1 = new Team { Seed = 5, Name = "Oklahoma" },
                        Team2 = new Team { Seed = 12, Name = "Portland" }
                    }),
                    new MatchupGroup(4, new Matchup
                    {
                        NextMatchup = 34,
                        NextMatchupTeam = 2,
                        Regional = 1,
                        MatchupClass = "matchup-4",
                        Team1 = new Team { Seed = 4, Name = "UCLA" },
                        Team2 = new Team { Seed = 13, Name = "Sacramento St" }
                    }),
                    new MatchupGroup(5, new Matchup
                    {
                        NextMatchup = 35,
                        NextMatchupTeam = 1,
                        Regional = 1,
                        MatchupClass = "matchup-5",
                        Team1 = new Team { Seed = 6, Name = "Creighton" },
                        Team2 = new Team { Seed = 11, Name = "Illinois/Mississippi St" }
                    }),
                    new MatchupGroup(6, new Matchup
                    {
                        NextMatchup = 35,
                        NextMatchupTeam = 2,
                        Regional = 1,
                        MatchupClass = "matchup-6",
                        Team1 = new Team { Seed = 3, Name = "Notre Dame" },
                        Team2 = new Team { Seed = 14, Name = "Southern Utah" }
                    }),
                    new MatchupGroup(7, new Matchup
                    {
                        NextMatchup = 36,
                        NextMatchupTeam = 1,
                        Regional = 1,
                        MatchupClass = "matchup-7",
                        Team1 = new Team { Seed = 7, Name = "Arizona" },
                        Team2 = new Team { Seed = 10, Name = "West Virginia" }
                    }),
                    new MatchupGroup(8, new Matchup
                    {
                        NextMatchup = 36,
                        NextMatchupTeam = 2,
                        Regional = 1,
                        MatchupClass = "matchup-8",
                        Team1 = new Team { Seed = 2, Name = "Maryland" },
                        Team2 = new Team { Seed = 15, Name = "Holy Cross" }
                    }),
                    new MatchupGroup(33, new Matchup
                    {
                        NextMatchup = 49,
                        NextMatchupTeam = 1,
                        Regional = 1,
                        MatchupClass = "matchup-33",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(34, new Matchup
                    {
                        NextMatchup = 49,
                        NextMatchupTeam = 2,
                        Regional = 1,
                        MatchupClass = "matchup-34",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(35, new Matchup
                    {
                        NextMatchup = 50,
                        NextMatchupTeam = 1,
                        Regional = 1,
                        MatchupClass = "matchup-35",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(36, new Matchup
                    {
                        NextMatchup = 50,
                        NextMatchupTeam = 2,
                        Regional = 1,
                        MatchupClass = "matchup-36",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(49, new Matchup
                    {
                        NextMatchup = 57,
                        NextMatchupTeam = 1,
                        Regional = 1,
                        MatchupClass = "matchup-49",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(50, new Matchup
                    {
                        NextMatchup = 57,
                        NextMatchupTeam = 2,
                        Regional = 1,
                        MatchupClass = "matchup-50",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(57, new Matchup
                    {
                        NextMatchup = 61,
                        NextMatchupTeam = 1,
                        Regional = 1,
                        MatchupClass = "matchup-57",
                        Team1 = new Team(),
                        Team2 = new Team()
                    })
                }
            )
        );
    }

    private RegionalMatchupGroup BuildRegion2()
    {
        return new RegionalMatchupGroup(
            2,
            new RegionalMatchupDetails(
                "region-2",
                new List<MatchupGroup>
                {
                    new MatchupGroup(9, new Matchup
                    {
                        NextMatchup = 37,
                        NextMatchupTeam = 1,
                        Regional = 2,
                        MatchupClass = "matchup-9",
                        Team1 = new Team { Seed = 1, Name = "Stanford" },
                        Team2 = new Team { Seed = 16, Name = "Southern/Sacred Heart" }
                    }),
                    new MatchupGroup(10, new Matchup
                    {
                        NextMatchup = 37,
                        NextMatchupTeam = 2,
                        Regional = 2,
                        MatchupClass = "matchup-10",
                        Team1 = new Team { Seed = 8, Name = "Ole Miss" },
                        Team2 = new Team { Seed = 9, Name = "Gonzaga" }
                    }),
                    new MatchupGroup(11, new Matchup
                    {
                        NextMatchup = 38,
                        NextMatchupTeam = 1,
                        Regional = 2,
                        MatchupClass = "matchup-11",
                        Team1 = new Team { Seed = 5, Name = "Louisville" },
                        Team2 = new Team { Seed = 12, Name = "Drake" }
                    }),
                    new MatchupGroup(12, new Matchup
                    {
                        NextMatchup = 38,
                        NextMatchupTeam = 2,
                        Regional = 2,
                        MatchupClass = "matchup-12",
                        Team1 = new Team { Seed = 4, Name = "Texas" },
                        Team2 = new Team { Seed = 13, Name = "East Carolina" }
                    }),
                    new MatchupGroup(13, new Matchup
                    {
                        NextMatchup = 39,
                        NextMatchupTeam = 1,
                        Regional = 2,
                        MatchupClass = "matchup-13",
                        Team1 = new Team { Seed = 6, Name = "Colorado" },
                        Team2 = new Team { Seed = 11, Name = "Middle Tennessee" }
                    }),
                    new MatchupGroup(14, new Matchup
                    {
                        NextMatchup = 39,
                        NextMatchupTeam = 2,
                        Regional = 2,
                        MatchupClass = "matchup-14",
                        Team1 = new Team { Seed = 3, Name = "Duke" },
                        Team2 = new Team { Seed = 14, Name = "Iona" }
                    }),
                    new MatchupGroup(15, new Matchup
                    {
                        NextMatchup = 40,
                        NextMatchupTeam = 1,
                        Regional = 2,
                        MatchupClass = "matchup-15",
                        Team1 = new Team { Seed = 7, Name = "Florida St" },
                        Team2 = new Team { Seed = 10, Name = "Georgia" }
                    }),
                    new MatchupGroup(16, new Matchup
                    {
                        NextMatchup = 40,
                        NextMatchupTeam = 2,
                        Regional = 2,
                        MatchupClass = "matchup-16",
                        Team1 = new Team { Seed = 2, Name = "Iowa" },
                        Team2 = new Team { Seed = 15, Name = "Southeastern Louisiana" }
                    }),
                    new MatchupGroup(37, new Matchup
                    {
                        NextMatchup = 51,
                        NextMatchupTeam = 1,
                        Regional = 2,
                        MatchupClass = "matchup-37",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(38, new Matchup
                    {
                        NextMatchup = 51,
                        NextMatchupTeam = 2,
                        Regional = 2,
                        MatchupClass = "matchup-38",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(39, new Matchup
                    {
                        NextMatchup = 52,
                        NextMatchupTeam = 1,
                        Regional = 2,
                        MatchupClass = "matchup-39",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(40, new Matchup
                    {
                        NextMatchup = 52,
                        NextMatchupTeam = 2,
                        Regional = 2,
                        MatchupClass = "matchup-40",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(51, new Matchup
                    {
                        NextMatchup = 58,
                        NextMatchupTeam = 1,
                        Regional = 2,
                        MatchupClass = "matchup-51",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(52, new Matchup
                    {
                        NextMatchup = 58,
                        NextMatchupTeam = 2,
                        Regional = 2,
                        MatchupClass = "matchup-52",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(58, new Matchup
                    {
                        NextMatchup = 61,
                        NextMatchupTeam = 2,
                        Regional = 2,
                        MatchupClass = "matchup-58",
                        Team1 = new Team(),
                        Team2 = new Team()
                    })
                }
            )
        );
    }

    private RegionalMatchupGroup BuildRegion3()
    {
        return new RegionalMatchupGroup(
            3,
            new RegionalMatchupDetails(
                "region-3",
                new List<MatchupGroup>
                {
                    new MatchupGroup(17, new Matchup
                    {
                        NextMatchup = 41,
                        NextMatchupTeam = 1,
                        Regional = 3,
                        MatchupClass = "matchup-17",
                        Team1 = new Team { Seed = 1, Name = "Indiana" },
                        Team2 = new Team { Seed = 16, Name = "Tennessee Tech/Monmouth" }
                    }),
                    new MatchupGroup(18, new Matchup
                    {
                        NextMatchup = 41,
                        NextMatchupTeam = 2,
                        Regional = 3,
                        MatchupClass = "matchup-18",
                        Team1 = new Team { Seed = 8, Name = "Oklahoma St" },
                        Team2 = new Team { Seed = 9, Name = "Miami" }
                    }),
                    new MatchupGroup(19, new Matchup
                    {
                        NextMatchup = 42,
                        NextMatchupTeam = 1,
                        Regional = 3,
                        MatchupClass = "matchup-19",
                        Team1 = new Team { Seed = 5, Name = "Washington St" },
                        Team2 = new Team { Seed = 12, Name = "FGCU" }
                    }),
                    new MatchupGroup(20, new Matchup
                    {
                        NextMatchup = 42,
                        NextMatchupTeam = 2,
                        Regional = 3,
                        MatchupClass = "matchup-20",
                        Team1 = new Team { Seed = 4, Name = "Villanova" },
                        Team2 = new Team { Seed = 13, Name = "Cleveland St" }
                    }),
                    new MatchupGroup(21, new Matchup
                    {
                        NextMatchup = 43,
                        NextMatchupTeam = 1,
                        Regional = 3,
                        MatchupClass = "matchup-21",
                        Team1 = new Team { Seed = 6, Name = "Michigan" },
                        Team2 = new Team { Seed = 11, Name = "UNLV" }
                    }),
                    new MatchupGroup(22, new Matchup
                    {
                        NextMatchup = 43,
                        NextMatchupTeam = 2,
                        Regional = 3,
                        MatchupClass = "matchup-22",
                        Team1 = new Team { Seed = 3, Name = "LSU" },
                        Team2 = new Team { Seed = 14, Name = "Hawaii" }
                    }),
                    new MatchupGroup(23, new Matchup
                    {
                        NextMatchup = 44,
                        NextMatchupTeam = 1,
                        Regional = 3,
                        MatchupClass = "matchup-23",
                        Team1 = new Team { Seed = 7, Name = "NC State" },
                        Team2 = new Team { Seed = 10, Name = "Princeton" }
                    }),
                    new MatchupGroup(24, new Matchup
                    {
                        NextMatchup = 44,
                        NextMatchupTeam = 2,
                        Regional = 3,
                        MatchupClass = "matchup-24",
                        Team1 = new Team { Seed = 2, Name = "Utah" },
                        Team2 = new Team { Seed = 15, Name = "Gardner-Webb" }
                    }),
                    new MatchupGroup(41, new Matchup
                    {
                        NextMatchup = 53,
                        NextMatchupTeam = 1,
                        Regional = 3,
                        MatchupClass = "matchup-41",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(42, new Matchup
                    {
                        NextMatchup = 53,
                        NextMatchupTeam = 2,
                        Regional = 3,
                        MatchupClass = "matchup-42",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(43, new Matchup
                    {
                        NextMatchup = 54,
                        NextMatchupTeam = 1,
                        Regional = 3,
                        MatchupClass = "matchup-43",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(44, new Matchup
                    {
                        NextMatchup = 54,
                        NextMatchupTeam = 2,
                        Regional = 3,
                        MatchupClass = "matchup-44",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(53, new Matchup
                    {
                        NextMatchup = 59,
                        NextMatchupTeam = 1,
                        Regional = 3,
                        MatchupClass = "matchup-53",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(54, new Matchup
                    {
                        NextMatchup = 59,
                        NextMatchupTeam = 2,
                        Regional = 3,
                        MatchupClass = "matchup-54",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(59, new Matchup
                    {
                        NextMatchup = 62,
                        NextMatchupTeam = 1,
                        Regional = 3,
                        MatchupClass = "matchup-59",
                        Team1 = new Team(),
                        Team2 = new Team()
                    })
                }
            )
        );
    }

    private RegionalMatchupGroup BuildRegion4()
    {
        return new RegionalMatchupGroup(
            4,
            new RegionalMatchupDetails(
                "region-4",
                new List<MatchupGroup>
                {
                    new MatchupGroup(25, new Matchup
                    {
                        NextMatchup = 45,
                        NextMatchupTeam = 1,
                        Regional = 4,
                        MatchupClass = "matchup-25",
                        Team1 = new Team { Seed = 1, Name = "Virginia Tech" },
                        Team2 = new Team { Seed = 16, Name = "Chattanooga" }
                    }),
                    new MatchupGroup(26, new Matchup
                    {
                        NextMatchup = 45,
                        NextMatchupTeam = 2,
                        Regional = 4,
                        MatchupClass = "matchup-26",
                        Team1 = new Team { Seed = 8, Name = "USC" },
                        Team2 = new Team { Seed = 9, Name = "South Dakota St" }
                    }),
                    new MatchupGroup(27, new Matchup
                    {
                        NextMatchup = 46,
                        NextMatchupTeam = 1,
                        Regional = 4,
                        MatchupClass = "matchup-27",
                        Team1 = new Team { Seed = 5, Name = "Iowa St" },
                        Team2 = new Team { Seed = 12, Name = "Toledo" }
                    }),
                    new MatchupGroup(28, new Matchup
                    {
                        NextMatchup = 46,
                        NextMatchupTeam = 2,
                        Regional = 4,
                        MatchupClass = "matchup-28",
                        Team1 = new Team { Seed = 4, Name = "Tennessee" },
                        Team2 = new Team { Seed = 13, Name = "St Louis" }
                    }),
                    new MatchupGroup(29, new Matchup
                    {
                        NextMatchup = 47,
                        NextMatchupTeam = 1,
                        Regional = 4,
                        MatchupClass = "matchup-29",
                        Team1 = new Team { Seed = 6, Name = "North Carolina" },
                        Team2 = new Team { Seed = 11, Name = "Purdue/St John\'s" }
                    }),
                    new MatchupGroup(30, new Matchup
                    {
                        NextMatchup = 47,
                        NextMatchupTeam = 2,
                        Regional = 4,
                        MatchupClass = "matchup-30",
                        Team1 = new Team { Seed = 3, Name = "Ohio St" },
                        Team2 = new Team { Seed = 14, Name = "James Madison" }
                    }),
                    new MatchupGroup(31, new Matchup
                    {
                        NextMatchup = 48,
                        NextMatchupTeam = 1,
                        Regional = 4,
                        MatchupClass = "matchup-31",
                        Team1 = new Team { Seed = 7, Name = "Baylor" },
                        Team2 = new Team { Seed = 10, Name = "Alabama" }
                    }),
                    new MatchupGroup(32, new Matchup
                    {
                        NextMatchup = 48,
                        NextMatchupTeam = 2,
                        Regional = 4,
                        MatchupClass = "matchup-32",
                        Team1 = new Team { Seed = 2, Name = "UConn" },
                        Team2 = new Team { Seed = 15, Name = "Vermont" }
                    }),
                    new MatchupGroup(45, new Matchup
                    {
                        NextMatchup = 55,
                        NextMatchupTeam = 1,
                        Regional = 4,
                        MatchupClass = "matchup-45",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(46, new Matchup
                    {
                        NextMatchup = 55,
                        NextMatchupTeam = 2,
                        Regional = 4,
                        MatchupClass = "matchup-46",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(47, new Matchup
                    {
                        NextMatchup = 56,
                        NextMatchupTeam = 1,
                        Regional = 4,
                        MatchupClass = "matchup-47",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(48, new Matchup
                    {
                        NextMatchup = 56,
                        NextMatchupTeam = 2,
                        Regional = 4,
                        MatchupClass = "matchup-48",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(55, new Matchup
                    {
                        NextMatchup = 60,
                        NextMatchupTeam = 1,
                        Regional = 4,
                        MatchupClass = "matchup-55",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(56, new Matchup
                    {
                        NextMatchup = 60,
                        NextMatchupTeam = 2,
                        Regional = 4,
                        MatchupClass = "matchup-56",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(60, new Matchup
                    {
                        NextMatchup = 62,
                        NextMatchupTeam = 2,
                        Regional = 4,
                        MatchupClass = "matchup-60",
                        Team1 = new Team(),
                        Team2 = new Team()
                    })
                }
            )
        );
    }

    private RegionalMatchupGroup BuildFinalFour()
    {
        return new RegionalMatchupGroup(
            5,
            new RegionalMatchupDetails(
                "final-four",
                new List<MatchupGroup>
                {
                    new MatchupGroup(61, new Matchup
                    {
                        NextMatchup = 63,
                        NextMatchupTeam = 1,
                        Regional = 5,
                        MatchupClass = "matchup-61",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(62, new Matchup
                    {
                        NextMatchup = 63,
                        NextMatchupTeam = 2,
                        Regional = 5,
                        MatchupClass = "matchup-62",
                        Team1 = new Team(),
                        Team2 = new Team()
                    }),
                    new MatchupGroup(63, new Matchup
                    {
                        NextMatchup = 0,
                        NextMatchupTeam = 0,
                        Regional = 5,
                        MatchupClass = "matchup-63",
                        Team1 = new Team(),
                        Team2 = new Team()
                    })
                }
            )
        );
    }
}