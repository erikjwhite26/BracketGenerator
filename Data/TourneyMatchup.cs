class TourneyMatchup
{
	public Dictionary<int, RegionalMatchup> Matchups { get; set; } = new()
	{
		{
			1,
			new()
			{
				RegionalClass = "region-1",
				RegionalMatchups = new()
				{
					{
						1,
						new Matchup
						{
							NextMatchup = 33,
							NextMatchupTeam = 1,
							Regional = 1,
							MatchupClass = "matchup-1",
							Team1 = new() { Seed = 1, Name = "Alabama" },
							Team2 = new() { Seed = 16, Name = "Texas A&MCC/SE Missouri St" }
						}
					},
					{
						2,
						new Matchup
						{
							NextMatchup = 33,
							NextMatchupTeam = 2,
							Regional = 1,
							MatchupClass = "matchup-2",
							Team1 = new() { Seed = 8, Name = "Maryland" },
							Team2 = new() { Seed = 9, Name = "West Virginia" }
						}
					},
					{
						3,
						new Matchup
						{
							NextMatchup = 34,
							NextMatchupTeam = 1,
							Regional = 1,
							MatchupClass = "matchup-3",
							Team1 = new() { Seed = 5, Name = "San Diego St" },
							Team2 = new() { Seed = 12, Name = "Charleston" }
						}
					},
					{
						4,
						new Matchup
						{
							NextMatchup = 34,
							NextMatchupTeam = 2,
							Regional = 1,
							MatchupClass = "matchup-4",
							Team1 = new() { Seed = 4, Name = "Virginia" },
							Team2 = new() { Seed = 13, Name = "Furman" }
						}
					},
					{
						5,
						new Matchup
						{
							NextMatchup = 35,
							NextMatchupTeam = 1,
							Regional = 1,
							MatchupClass = "matchup-5",
							Team1 = new() { Seed = 6, Name = "Creighton" },
							Team2 = new() { Seed = 11, Name = "NC State" }
						}
					},
					{
						6,
						new Matchup
						{
							NextMatchup = 35,
							NextMatchupTeam = 2,
							Regional = 1,
							MatchupClass = "matchup-6",
							Team1 = new() { Seed = 3, Name = "Baylor" },
							Team2 = new() { Seed = 14, Name = "UC Santa Barbara" }
						}
					},
					{
						7,
						new Matchup
						{
							NextMatchup = 36,
							NextMatchupTeam = 1,
							Regional = 1,
							MatchupClass = "matchup-7",
							Team1 = new() { Seed = 7, Name = "Missouri" },
							Team2 = new() { Seed = 10, Name = "Utah St" }
						}
					},
					{
						8,
						new Matchup
						{
							NextMatchup = 36,
							NextMatchupTeam = 2,
							Regional = 1,
							MatchupClass = "matchup-8",
							Team1 = new() { Seed = 2, Name = "Arizona" },
							Team2 = new() { Seed = 15, Name = "Princeton" }
						}
					},
					{
						33,
						new Matchup
						{
							NextMatchup = 49,
							NextMatchupTeam = 1,
							Regional = 1,
							MatchupClass = "matchup-33",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						34,
						new Matchup
						{
							NextMatchup = 49,
							NextMatchupTeam = 2,
							Regional = 1,
							MatchupClass = "matchup-34",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						35,
						new Matchup
						{
							NextMatchup = 50,
							NextMatchupTeam = 1,
							Regional = 1,
							MatchupClass = "matchup-35",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						36,
						new Matchup
						{
							NextMatchup = 50,
							NextMatchupTeam = 2,
							Regional = 1,
							MatchupClass = "matchup-36",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						49,
						new Matchup
						{
							NextMatchup = 57,
							NextMatchupTeam = 1,
							Regional = 1,
							MatchupClass = "matchup-49",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						50,
						new Matchup
						{
							NextMatchup = 57,
							NextMatchupTeam = 2,
							Regional = 1,
							MatchupClass = "matchup-50",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						57,
						new Matchup
						{
							NextMatchup = 61,
							NextMatchupTeam = 1,
							Regional = 1,
							MatchupClass = "matchup-57",
							Team1 = new() { },
							Team2 = new() { }
						}
					}
				}
			}
		},
		{
			2,
			new()
			{
				RegionalClass = "region-2",
				RegionalMatchups = new()
				{
					{
						9,
						new Matchup
						{
							NextMatchup = 37,
							NextMatchupTeam = 1,
							Regional = 2,
							MatchupClass = "matchup-9",
							Team1 = new() { Seed = 1, Name = "Purdue" },
							Team2 = new() { Seed = 16, Name = "Texas Southern/Farleigh Dickinson" }
						}
					},
					{
						10,
						new Matchup
						{
							NextMatchup = 37,
							NextMatchupTeam = 2,
							Regional = 2,
							MatchupClass = "matchup-10",
							Team1 = new() { Seed = 8, Name = "Memphis" },
							Team2 = new() { Seed = 9, Name = "Florida Atlantic" }
						}
					},
					{
						11,
						new Matchup
						{
							NextMatchup = 38,
							NextMatchupTeam = 1,
							Regional = 2,
							MatchupClass = "matchup-11",
							Team1 = new() { Seed = 5, Name = "Duke" },
							Team2 = new() { Seed = 12, Name = "Oral Roberts" }
						}
					},
					{
						12,
						new Matchup
						{
							NextMatchup = 38,
							NextMatchupTeam = 2,
							Regional = 2,
							MatchupClass = "matchup-12",
							Team1 = new() { Seed = 4, Name = "Tennessee" },
							Team2 = new() { Seed = 13, Name = "Louisiana" }
						}
					},
					{
						13,
						new Matchup
						{
							NextMatchup = 39,
							NextMatchupTeam = 1,
							Regional = 2,
							MatchupClass = "matchup-13",
							Team1 = new() { Seed = 6, Name = "Kentucky" },
							Team2 = new() { Seed = 11, Name = "Providence" }
						}
					},
					{
						14,
						new Matchup
						{
							NextMatchup = 39,
							NextMatchupTeam = 2,
							Regional = 2,
							MatchupClass = "matchup-14",
							Team1 = new() { Seed = 3, Name = "Kansas St" },
							Team2 = new() { Seed = 14, Name = "Montana St" }
						}
					},
					{
						15,
						new Matchup
						{
							NextMatchup = 40,
							NextMatchupTeam = 1,
							Regional = 2,
							MatchupClass = "matchup-15",
							Team1 = new() { Seed = 7, Name = "Michigan St" },
							Team2 = new() { Seed = 10, Name = "USC" }
						}
					},
					{
						16,
						new Matchup
						{
							NextMatchup = 40,
							NextMatchupTeam = 2,
							Regional = 2,
							MatchupClass = "matchup-16",
							Team1 = new() { Seed = 2, Name = "Marquette" },
							Team2 = new() { Seed = 15, Name = "Vermont" }
						}
					},
					{
						37,
						new Matchup
						{
							NextMatchup = 51,
							NextMatchupTeam = 1,
							Regional = 2,
							MatchupClass = "matchup-37",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						38,
						new Matchup
						{
							NextMatchup = 51,
							NextMatchupTeam = 2,
							Regional = 2,
							MatchupClass = "matchup-38",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						39,
						new Matchup
						{
							NextMatchup = 52,
							NextMatchupTeam = 1,
							Regional = 2,
							MatchupClass = "matchup-39",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						40,
						new Matchup
						{
							NextMatchup = 52,
							NextMatchupTeam = 2,
							Regional = 2,
							MatchupClass = "matchup-40",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						51,
						new Matchup
						{
							NextMatchup = 58,
							NextMatchupTeam = 1,
							Regional = 2,
							MatchupClass = "matchup-51",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						52,
						new Matchup
						{
							NextMatchup = 58,
							NextMatchupTeam = 2,
							Regional = 2,
							MatchupClass = "matchup-52",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						58,
						new Matchup
						{
							NextMatchup = 61,
							NextMatchupTeam = 2,
							Regional = 2,
							MatchupClass = "matchup-58",
							Team1 = new() { },
							Team2 = new() { }
						}
					}
				}
			}
		},
		{
			3,
			new()
			{
				RegionalClass = "region-3",
				RegionalMatchups = new()
				{
					{
						17,
						new Matchup
						{
							NextMatchup = 41,
							NextMatchupTeam = 1,
							Regional = 3,
							MatchupClass = "matchup-17",
							Team1 = new() { Seed = 1, Name = "Houston" },
							Team2 = new() { Seed = 16, Name = "N Kentucky" }
						}
					},
					{
						18,
						new Matchup
						{
							NextMatchup = 41,
							NextMatchupTeam = 2,
							Regional = 3,
							MatchupClass = "matchup-18",
							Team1 = new() { Seed = 8, Name = "Iowa" },
							Team2 = new() { Seed = 9, Name = "Auburn" }
						}
					},
					{
						19,
						new Matchup
						{
							NextMatchup = 42,
							NextMatchupTeam = 1,
							Regional = 3,
							MatchupClass = "matchup-19",
							Team1 = new() { Seed = 5, Name = "Miami" },
							Team2 = new() { Seed = 12, Name = "Drake" }
						}
					},
					{
						20,
						new Matchup
						{
							NextMatchup = 42,
							NextMatchupTeam = 2,
							Regional = 3,
							MatchupClass = "matchup-20",
							Team1 = new() { Seed = 4, Name = "Indiana" },
							Team2 = new() { Seed = 13, Name = "Kent St" }
						}
					},
					{
						21,
						new Matchup
						{
							NextMatchup = 43,
							NextMatchupTeam = 1,
							Regional = 3,
							MatchupClass = "matchup-21",
							Team1 = new() { Seed = 6, Name = "Iowa St" },
							Team2 = new() { Seed = 11, Name = "Mississippi St/Pittsburgh" }
						}
					},
					{
						22,
						new Matchup
						{
							NextMatchup = 43,
							NextMatchupTeam = 2,
							Regional = 3,
							MatchupClass = "matchup-22",
							Team1 = new() { Seed = 3, Name = "Xavier" },
							Team2 = new() { Seed = 14, Name = "Kennesaw St" }
						}
					},
					{
						23,
						new Matchup
						{
							NextMatchup = 44,
							NextMatchupTeam = 1,
							Regional = 3,
							MatchupClass = "matchup-23",
							Team1 = new() { Seed = 7, Name = "Texas A&M" },
							Team2 = new() { Seed = 10, Name = "Penn St" }
						}
					},
					{
						24,
						new Matchup
						{
							NextMatchup = 44,
							NextMatchupTeam = 2,
							Regional = 3,
							MatchupClass = "matchup-24",
							Team1 = new() { Seed = 2, Name = "Texas" },
							Team2 = new() { Seed = 15, Name = "Colgate" }
						}
					},
					{
						41,
						new Matchup
						{
							NextMatchup = 53,
							NextMatchupTeam = 1,
							Regional = 3,
							MatchupClass = "matchup-41",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						42,
						new Matchup
						{
							NextMatchup = 53,
							NextMatchupTeam = 2,
							Regional = 3,
							MatchupClass = "matchup-42",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						43,
						new Matchup
						{
							NextMatchup = 54,
							NextMatchupTeam = 1,
							Regional = 3,
							MatchupClass = "matchup-43",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						44,
						new Matchup
						{
							NextMatchup = 54,
							NextMatchupTeam = 2,
							Regional = 3,
							MatchupClass = "matchup-44",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						53,
						new Matchup
						{
							NextMatchup = 59,
							NextMatchupTeam = 1,
							Regional = 3,
							MatchupClass = "matchup-53",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						54,
						new Matchup
						{
							NextMatchup = 59,
							NextMatchupTeam = 2,
							Regional = 3,
							MatchupClass = "matchup-54",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						59,
						new Matchup
						{
							NextMatchup = 62,
							NextMatchupTeam = 1,
							Regional = 3,
							MatchupClass = "matchup-59",
							Team1 = new() { },
							Team2 = new() { }
						}
					}
				}
			}
		},
		{
			4,
			new()
			{
				RegionalClass = "region-4",
				RegionalMatchups = new()
				{
					{
						25,
						new Matchup
						{
							NextMatchup = 45,
							NextMatchupTeam = 1,
							Regional = 4,
							MatchupClass = "matchup-25",
							Team1 = new() { Seed = 1, Name = "Kansas" },
							Team2 = new() { Seed = 16, Name = "Howard" }
						}
					},
					{
						26,
						new Matchup
						{
							NextMatchup = 45,
							NextMatchupTeam = 2,
							Regional = 4,
							MatchupClass = "matchup-26",
							Team1 = new() { Seed = 8, Name = "Arkansas" },
							Team2 = new() { Seed = 9, Name = "Illinois" }
						}
					},
					{
						27,
						new Matchup
						{
							NextMatchup = 46,
							NextMatchupTeam = 1,
							Regional = 4,
							MatchupClass = "matchup-27",
							Team1 = new() { Seed = 5, Name = "Saint Mary\'s" },
							Team2 = new() { Seed = 12, Name = "VCU" }
						}
					},
					{
						28,
						new Matchup
						{
							NextMatchup = 46,
							NextMatchupTeam = 2,
							Regional = 4,
							MatchupClass = "matchup-28",
							Team1 = new() { Seed = 4, Name = "UConn" },
							Team2 = new() { Seed = 13, Name = "Iona" }
						}
					},
					{
						29,
						new Matchup
						{
							NextMatchup = 47,
							NextMatchupTeam = 1,
							Regional = 4,
							MatchupClass = "matchup-29",
							Team1 = new() { Seed = 6, Name = "TCU" },
							Team2 = new() { Seed = 11, Name = "Arizona St/Nevada" }
						}
					},
					{
						30,
						new Matchup
						{
							NextMatchup = 47,
							NextMatchupTeam = 2,
							Regional = 4,
							MatchupClass = "matchup-30",
							Team1 = new() { Seed = 3, Name = "Gonzaga" },
							Team2 = new() { Seed = 14, Name = "Grand Canyon" }
      }
					},
					{
						31,
						new Matchup
						{
							NextMatchup = 48,
							NextMatchupTeam = 1,
							Regional = 4,
							MatchupClass = "matchup-31",
							Team1 = new() { Seed = 7, Name = "Northwestern" },
							Team2 = new() { Seed = 10, Name = "Boise St" }
						}
					},
					{
						32,
						new Matchup
						{
							NextMatchup = 48,
							NextMatchupTeam = 2,
							Regional = 4,
							MatchupClass = "matchup-32",
							Team1 = new() { Seed = 2, Name = "UCLA" },
							Team2 = new() { Seed = 15, Name = "UNC Asheville" }
						}
					},
					{
						45,
						new Matchup
						{
							NextMatchup = 55,
							NextMatchupTeam = 1,
							Regional = 4,
							MatchupClass = "matchup-45",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						46,
						new Matchup
						{
							NextMatchup = 55,
							NextMatchupTeam = 2,
							Regional = 4,
							MatchupClass = "matchup-46",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						47,
						new Matchup
						{
							NextMatchup = 56,
							NextMatchupTeam = 1,
							Regional = 4,
							MatchupClass = "matchup-47",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						48,
						new Matchup
						{
							NextMatchup = 56,
							NextMatchupTeam = 2,
							Regional = 4,
							MatchupClass = "matchup-48",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						55,
						new Matchup
						{
							NextMatchup = 60,
							NextMatchupTeam = 1,
							Regional = 4,
							MatchupClass = "matchup-55",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						56,
						new Matchup
						{
							NextMatchup = 60,
							NextMatchupTeam = 2,
							Regional = 4,
							MatchupClass = "matchup-56",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						60,
						new Matchup
						{
							NextMatchup = 62,
							NextMatchupTeam = 2,
							Regional = 4,
							MatchupClass = "matchup-60",
							Team1 = new() { },
							Team2 = new() { }
						}
					}
				}
			}
		},
		{
			5,
			new()
			{
				RegionalClass = "final-four",
				RegionalMatchups = new()
				{
					{
						61,
						new Matchup
						{
							NextMatchup = 63,
							NextMatchupTeam = 1,
							Regional = 5,
							MatchupClass = "matchup-61",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						62,
						new Matchup
						{
							NextMatchup = 63,
							NextMatchupTeam = 2,
							Regional = 5,
							MatchupClass = "matchup-62",
							Team1 = new() { },
							Team2 = new() { }
						}
					},
					{
						63,
						new Matchup
						{
							NextMatchup = 0,
							Regional = 5,
							MatchupClass = "matchup-63",
							Team1 = new() { },
							Team2 = new() { }
						}
					}
				}
			}
		}
	};
}
