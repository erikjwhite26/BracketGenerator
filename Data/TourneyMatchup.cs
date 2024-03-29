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
							Team1 = new() { Seed = 1, Name = "UConn" },
							Team2 = new() { Seed = 16, Name = "Stetson" }
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
							Team1 = new() { Seed = 8, Name = "FAU" },
							Team2 = new() { Seed = 9, Name = "Northwestern" }
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
							Team2 = new() { Seed = 12, Name = "UAB" }
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
							Team1 = new() { Seed = 4, Name = "Auburn" },
							Team2 = new() { Seed = 13, Name = "Yale" }
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
							Team1 = new() { Seed = 6, Name = "BYU" },
							Team2 = new() { Seed = 11, Name = "Duquesne" }
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
							Team1 = new() { Seed = 3, Name = "Illinois" },
							Team2 = new() { Seed = 14, Name = "Morehead St" }
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
							Team1 = new() { Seed = 7, Name = "Washington St" },
							Team2 = new() { Seed = 10, Name = "Drake" }
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
							Team1 = new() { Seed = 2, Name = "Iowa St" },
							Team2 = new() { Seed = 15, Name = "South Dakota St" }
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
							Team1 = new() { Seed = 1, Name = "North Carolina" },
							Team2 = new() { Seed = 16, Name = "Wagner" }
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
							Team1 = new() { Seed = 8, Name = "Mississippi St" },
							Team2 = new() { Seed = 9, Name = "Michigan St" }
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
							Team1 = new() { Seed = 5, Name = "Saint Mary\'s" },
							Team2 = new() { Seed = 12, Name = "Grand Canyon" }
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
							Team1 = new() { Seed = 4, Name = "Alabama" },
							Team2 = new() { Seed = 13, Name = "Charleston" }
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
							Team1 = new() { Seed = 6, Name = "Clemson" },
							Team2 = new() { Seed = 11, Name = "New Mexico" }
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
							Team1 = new() { Seed = 3, Name = "Baylor" },
							Team2 = new() { Seed = 14, Name = "Colgate" }
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
							Team1 = new() { Seed = 7, Name = "Dayton" },
							Team2 = new() { Seed = 10, Name = "Nevada" }
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
							Team1 = new() { Seed = 2, Name = "Arizona" },
							Team2 = new() { Seed = 15, Name = "Long Beach St" }
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
							Team2 = new() { Seed = 16, Name = "Longwood" }
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
							Team1 = new() { Seed = 8, Name = "Nebraska" },
							Team2 = new() { Seed = 9, Name = "Texas A&M" }
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
							Team1 = new() { Seed = 5, Name = "Wisconsin" },
							Team2 = new() { Seed = 12, Name = "James Madison" }
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
							Team1 = new() { Seed = 4, Name = "Duke" },
							Team2 = new() { Seed = 13, Name = "Vermont" }
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
							Team1 = new() { Seed = 6, Name = "Texas Tech" },
							Team2 = new() { Seed = 11, Name = "NC State" }
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
							Team1 = new() { Seed = 3, Name = "Kentucky" },
							Team2 = new() { Seed = 14, Name = "Oakland" }
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
							Team1 = new() { Seed = 7, Name = "Florida" },
							Team2 = new() { Seed = 10, Name = "Colorado" }
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
							Team1 = new() { Seed = 2, Name = "Marquette" },
							Team2 = new() { Seed = 15, Name = "Western Kentucky" }
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
							Team1 = new() { Seed = 1, Name = "Purdue" },
							Team2 = new() { Seed = 16, Name = "Grambling St" }
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
							Team1 = new() { Seed = 8, Name = "Utah St" },
							Team2 = new() { Seed = 9, Name = "TCU" }
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
							Team1 = new() { Seed = 5, Name = "Gonzaga" },
							Team2 = new() { Seed = 12, Name = "McNeese" }
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
							Team1 = new() { Seed = 4, Name = "Kansas" },
							Team2 = new() { Seed = 13, Name = "Samford" }
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
							Team1 = new() { Seed = 6, Name = "South Carolina" },
							Team2 = new() { Seed = 11, Name = "Oregon" }
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
							Team1 = new() { Seed = 3, Name = "Creighton" },
							Team2 = new() { Seed = 14, Name = "Akron" }
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
							Team1 = new() { Seed = 7, Name = "Texas" },
							Team2 = new() { Seed = 10, Name = "Colorado St" }
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
							Team1 = new() { Seed = 2, Name = "Tennessee" },
							Team2 = new() { Seed = 15, Name = "Saint Peter\'s" }
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
