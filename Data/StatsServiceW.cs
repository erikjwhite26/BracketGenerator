using BlazorApp.Entities;
namespace BlazorApp.Data;
class StatsServiceW
{
//https://mcubed.net/ncaab/seeds.shtml
	public List<StatDetails> HistoricStats { get; } = new List<StatDetails>{
		new StatDetails{
			Id = "1",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.50 },
				new StatProbability { Id=2, Probability=.62 },
				new StatProbability { Id=3, Probability=.74 },
				new StatProbability { Id=4, Probability=.81 },
				new StatProbability { Id=5, Probability=.92 },
				new StatProbability { Id=6, Probability=.88 },
				new StatProbability { Id=7, Probability=.80 },
				new StatProbability { Id=8, Probability=.96 },
				new StatProbability { Id=9, Probability=.97 },
				new StatProbability { Id=10, Probability=.99 },
				new StatProbability { Id=11, Probability=.99 },
				new StatProbability { Id=12, Probability=.99 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "2",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.38 },
				new StatProbability { Id=2, Probability=.50 },
				new StatProbability { Id=3, Probability=.64 },
				new StatProbability { Id=4, Probability=.53 },
				new StatProbability { Id=5, Probability=.50 },
				new StatProbability { Id=6, Probability=.78 },
				new StatProbability { Id=7, Probability=.84 },
				new StatProbability { Id=8, Probability=.01 },
				new StatProbability { Id=9, Probability=.01 },
				new StatProbability { Id=10, Probability=.88 },
				new StatProbability { Id=11, Probability=.99 },
				new StatProbability { Id=12, Probability=.99 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.93 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "3",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.26 },
				new StatProbability { Id=2, Probability=.36 },
				new StatProbability { Id=3, Probability=.50 },
				new StatProbability { Id=4, Probability=.67 },
				new StatProbability { Id=5, Probability=.99 },
				new StatProbability { Id=6, Probability=.68 },
				new StatProbability { Id=7, Probability=.50 },
				new StatProbability { Id=8, Probability=.99 },
				new StatProbability { Id=9, Probability=.99 },
				new StatProbability { Id=10, Probability=.50 },
				new StatProbability { Id=11, Probability=.69 },
				new StatProbability { Id=12, Probability=.99 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "4",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.19 },
				new StatProbability { Id=2, Probability=.48 },
				new StatProbability { Id=3, Probability=.33 },
				new StatProbability { Id=4, Probability=.50 },
				new StatProbability { Id=5, Probability=.64 },
				new StatProbability { Id=6, Probability=.99 },
				new StatProbability { Id=7, Probability=.99 },
				new StatProbability { Id=8, Probability=.99 },
				new StatProbability { Id=9, Probability=.99 },
				new StatProbability { Id=10, Probability=.99 },
				new StatProbability { Id=11, Probability=.99 },
				new StatProbability { Id=12, Probability=.85 },
				new StatProbability { Id=13, Probability=.94 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "5",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.08 },
				new StatProbability { Id=2, Probability=.50 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.38 },
				new StatProbability { Id=5, Probability=.50 },
				new StatProbability { Id=6, Probability=.50 },
				new StatProbability { Id=7, Probability=.99 },
				new StatProbability { Id=8, Probability=.50 },
				new StatProbability { Id=9, Probability=.01 },
				new StatProbability { Id=10, Probability=.99 },
				new StatProbability { Id=11, Probability=.99 },
				new StatProbability { Id=12, Probability=.80 },
				new StatProbability { Id=13, Probability=.57 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "6",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.12 },
				new StatProbability { Id=2, Probability=.22 },
				new StatProbability { Id=3, Probability=.32 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.50 },
				new StatProbability { Id=6, Probability=.50 },
				new StatProbability { Id=7, Probability=.99 },
				new StatProbability { Id=8, Probability=.99 },
				new StatProbability { Id=9, Probability=.99 },
				new StatProbability { Id=10, Probability=.99 },
				new StatProbability { Id=11, Probability=.68 },
				new StatProbability { Id=12, Probability=.99 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "7",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.20 },
				new StatProbability { Id=2, Probability=.16 },
				new StatProbability { Id=3, Probability=.50 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.50 },
				new StatProbability { Id=8, Probability=.99 },
				new StatProbability { Id=9, Probability=.99 },
				new StatProbability { Id=10, Probability=.65 },
				new StatProbability { Id=11, Probability=.01 },
				new StatProbability { Id=12, Probability=.99 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "8",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.04 },
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.50 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 },
				new StatProbability { Id=8, Probability=.50 },
				new StatProbability { Id=9, Probability=.52 },
				new StatProbability { Id=10, Probability=.99 },
				new StatProbability { Id=11, Probability=.99 },
				new StatProbability { Id=12, Probability=.99 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "9",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.03 },
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.99 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 },
				new StatProbability { Id=8, Probability=.48 },
				new StatProbability { Id=9, Probability=.50 },
				new StatProbability { Id=10, Probability=.99 },
				new StatProbability { Id=11, Probability=.99 },
				new StatProbability { Id=12, Probability=.99 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "10",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.01 },
				new StatProbability { Id=2, Probability=.12 },
				new StatProbability { Id=3, Probability=.50 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.35 },
				new StatProbability { Id=8, Probability=.01 },
				new StatProbability { Id=9, Probability=.01 },
				new StatProbability { Id=10, Probability=.50 },
				new StatProbability { Id=11, Probability=.99 },
				new StatProbability { Id=12, Probability=.99 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "11",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.01 },
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.31 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.32 },
				new StatProbability { Id=7, Probability=.99 },
				new StatProbability { Id=8, Probability=.01 },
				new StatProbability { Id=9, Probability=.01 },
				new StatProbability { Id=10, Probability=.01 },
				new StatProbability { Id=11, Probability=.50 },
				new StatProbability { Id=12, Probability=.99 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "12",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.01 },
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.15 },
				new StatProbability { Id=5, Probability=.20 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 },
				new StatProbability { Id=8, Probability=.01 },
				new StatProbability { Id=9, Probability=.01 },
				new StatProbability { Id=10, Probability=.01 },
				new StatProbability { Id=11, Probability=.01 },
				new StatProbability { Id=12, Probability=.50 },
				new StatProbability { Id=13, Probability=.99 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "13",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.01 },
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.06 },
				new StatProbability { Id=5, Probability=.43 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 },
				new StatProbability { Id=8, Probability=.01 },
				new StatProbability { Id=9, Probability=.01 },
				new StatProbability { Id=10, Probability=.01 },
				new StatProbability { Id=11, Probability=.01 },
				new StatProbability { Id=12, Probability=.01 },
				new StatProbability { Id=13, Probability=.50 },
				new StatProbability { Id=14, Probability=.99 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "14",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.01 },
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 },
				new StatProbability { Id=8, Probability=.01 },
				new StatProbability { Id=9, Probability=.01 },
				new StatProbability { Id=10, Probability=.01 },
				new StatProbability { Id=11, Probability=.01 },
				new StatProbability { Id=12, Probability=.01 },
				new StatProbability { Id=13, Probability=.01 },
				new StatProbability { Id=14, Probability=.50 },
				new StatProbability { Id=15, Probability=.99 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "15",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.01 },
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 },
				new StatProbability { Id=8, Probability=.01 },
				new StatProbability { Id=9, Probability=.01 },
				new StatProbability { Id=10, Probability=.01 },
				new StatProbability { Id=11, Probability=.01 },
				new StatProbability { Id=12, Probability=.01 },
				new StatProbability { Id=13, Probability=.01 },
				new StatProbability { Id=14, Probability=.01 },
				new StatProbability { Id=15, Probability=.50 },
				new StatProbability { Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "16",
			Stats = new List<StatProbability>
			{
				new StatProbability { Id=1, Probability=.01 },
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 },
				new StatProbability { Id=8, Probability=.01 },
				new StatProbability { Id=9, Probability=.01 },
				new StatProbability { Id=10, Probability=.01 },
				new StatProbability { Id=11, Probability=.01 },
				new StatProbability { Id=12, Probability=.01 },
				new StatProbability { Id=13, Probability=.01 },
				new StatProbability { Id=14, Probability=.01 },
				new StatProbability { Id=15, Probability=.01 },
				new StatProbability { Id=16, Probability=.50 }
			}
		}
	};

	public List<StatDetails> FiveThirtyEightStats { get; } = new List<StatDetails>
	{
		new StatDetails {
			Id = "South Carolina",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.99 },
				new StatProbability { Id=4, Probability=.97 },
				new StatProbability { Id=5, Probability=.91 },
				new StatProbability { Id=6, Probability=.76 },
				new StatProbability { Id=7, Probability=.64 }
		}
		},
		new StatDetails {
			Id = "Indiana",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.95 },
				new StatProbability { Id=4, Probability=.80 },
				new StatProbability { Id=5, Probability=.54 },
				new StatProbability { Id=6, Probability=.33 },
				new StatProbability { Id=7, Probability=.08 }
		}
		},
		new StatDetails {
			Id = "Stanford",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.95 },
				new StatProbability { Id=4, Probability=.72 },
				new StatProbability { Id=5, Probability=.52 },
				new StatProbability { Id=6, Probability=.12 },
				new StatProbability { Id=7, Probability=.07 }
		}
		},
		new StatDetails {
			Id = "UConn",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.93 },
				new StatProbability { Id=4, Probability=.70 },
				new StatProbability { Id=5, Probability=.44 },
				new StatProbability { Id=6, Probability=.23 },
				new StatProbability { Id=7, Probability=.05 }
		}
		},
		new StatDetails {
			Id = "LSU",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.98 },
				new StatProbability { Id=3, Probability=.78 },
				new StatProbability { Id=4, Probability=.54 },
				new StatProbability { Id=5, Probability=.25 },
				new StatProbability { Id=6, Probability=.15 },
				new StatProbability { Id=7, Probability=.03 }
		}
		},
		new StatDetails {
			Id = "Iowa",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.90 },
				new StatProbability { Id=4, Probability=.70 },
				new StatProbability { Id=5, Probability=.28 },
				new StatProbability { Id=6, Probability=.06 },
				new StatProbability { Id=7, Probability=.03 }
		}
		},
		new StatDetails {
			Id = "Virginia Tech",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.90 },
				new StatProbability { Id=4, Probability=.53 },
				new StatProbability { Id=5, Probability=.25 },
				new StatProbability { Id=6, Probability=.12 },
				new StatProbability { Id=7, Probability=.02 }
		}
		},
		new StatDetails {
			Id = "Texas",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.98 },
				new StatProbability { Id=3, Probability=.77 },
				new StatProbability { Id=4, Probability=.21 },
				new StatProbability { Id=5, Probability=.11 },
				new StatProbability { Id=6, Probability=.02 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Tennessee",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.98 },
				new StatProbability { Id=3, Probability=.73 },
				new StatProbability { Id=4, Probability=.33 },
				new StatProbability { Id=5, Probability=.14 },
				new StatProbability { Id=6, Probability=.06 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Notre Dame",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.81 },
				new StatProbability { Id=4, Probability=.44 },
				new StatProbability { Id=5, Probability=.04 },
				new StatProbability { Id=6, Probability=.02 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Maryland",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.86 },
				new StatProbability { Id=4, Probability=.46 },
				new StatProbability { Id=5, Probability=.04 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Utah",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.99 },
				new StatProbability { Id=3, Probability=.80 },
				new StatProbability { Id=4, Probability=.29 },
				new StatProbability { Id=5, Probability=.09 },
				new StatProbability { Id=6, Probability=.04 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Ohio St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.96 },
				new StatProbability { Id=3, Probability=.68 },
				new StatProbability { Id=4, Probability=.20 },
				new StatProbability { Id=5, Probability=.08 },
				new StatProbability { Id=6, Probability=.03 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Iowa St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.84 },
				new StatProbability { Id=3, Probability=.26 },
				new StatProbability { Id=4, Probability=.11 },
				new StatProbability { Id=5, Probability=.05 },
				new StatProbability { Id=6, Probability=.02 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Duke",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.98 },
				new StatProbability { Id=3, Probability=.77 },
				new StatProbability { Id=4, Probability=.21 },
				new StatProbability { Id=5, Probability=.04 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Villanova",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.90 },
				new StatProbability { Id=3, Probability=.70 },
				new StatProbability { Id=4, Probability=.14 },
				new StatProbability { Id=5, Probability=.05 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Louisville",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.84 },
				new StatProbability { Id=3, Probability=.22 },
				new StatProbability { Id=4, Probability=.05 },
				new StatProbability { Id=5, Probability=.02 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "North Carolina",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.77 },
				new StatProbability { Id=3, Probability=.28 },
				new StatProbability { Id=4, Probability=.07 },
				new StatProbability { Id=5, Probability=.03 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "NC State",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.71 },
				new StatProbability { Id=3, Probability=.17 },
				new StatProbability { Id=4, Probability=.07 },
				new StatProbability { Id=5, Probability=.02 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Michigan",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.74 },
				new StatProbability { Id=3, Probability=.18 },
				new StatProbability { Id=4, Probability=.08 },
				new StatProbability { Id=5, Probability=.02 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "UCLA",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.95 },
				new StatProbability { Id=3, Probability=.70 },
				new StatProbability { Id=4, Probability=.02 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Oklahoma",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.80 },
				new StatProbability { Id=3, Probability=.26 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Creighton",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.72 },
				new StatProbability { Id=3, Probability=.16 },
				new StatProbability { Id=4, Probability=.06 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Baylor",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.61 },
				new StatProbability { Id=3, Probability=.05 },
				new StatProbability { Id=4, Probability=.02 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Colorado",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.59 },
				new StatProbability { Id=3, Probability=.15 },
				new StatProbability { Id=4, Probability=.04 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Washington St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.59 },
				new StatProbability { Id=3, Probability=.17 },
				new StatProbability { Id=4, Probability=.02 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "South Dakota St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.60 },
				new StatProbability { Id=3, Probability=.07 },
				new StatProbability { Id=4, Probability=.02 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Ole Miss",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.54 },
				new StatProbability { Id=3, Probability=.03 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Florida St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.52 },
				new StatProbability { Id=3, Probability=.05 },
				new StatProbability { Id=4, Probability=.02 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Arizona",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.57 },
				new StatProbability { Id=3, Probability=.09 },
				new StatProbability { Id=4, Probability=.03 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Oklahoma St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.52 },
				new StatProbability { Id=3, Probability=.03 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Georgia",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.48 },
				new StatProbability { Id=3, Probability=.04 },
				new StatProbability { Id=4, Probability=.02 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "USC",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.40 },
				new StatProbability { Id=3, Probability=.03 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Miami",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.48 },
				new StatProbability { Id=3, Probability=.03 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "FGCU",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.41 },
				new StatProbability { Id=3, Probability=.10 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Gonzaga",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.46 },
				new StatProbability { Id=3, Probability=.02 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "South Florida",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.57 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Princeton",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.29 },
				new StatProbability { Id=3, Probability=.04 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Alabama",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.39 },
				new StatProbability { Id=3, Probability=.02 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Middle Tennessee",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.41 },
				new StatProbability { Id=3, Probability=.08 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Marquette",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.43 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Purdue",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.17 },
				new StatProbability { Id=3, Probability=.03 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "West Virginia",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.43 },
				new StatProbability { Id=3, Probability=.05 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Mississippi St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.16 },
				new StatProbability { Id=3, Probability=.02 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "UNLV",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.26 },
				new StatProbability { Id=3, Probability=.03 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Toledo",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.16 },
				new StatProbability { Id=3, Probability=.02 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Illinois",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.12 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Drake",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.16 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Cleveland St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.10 },
				new StatProbability { Id=3, Probability=.03 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "St John\'s",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.05 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Portland",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.20 },
				new StatProbability { Id=3, Probability=.03 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "James Madison",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.04 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "East Carolina",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.02 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "St Louis",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.02 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Sacramento St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.05 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Gardner-Webb",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Tennessee Tech",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Hawaii",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.02 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Holy Cross",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Southern Utah",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Vermont",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Norfolk St",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Iona",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.02 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Southeastern Louisiana",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Chattanooga",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Monmouth",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Southern",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		},
		new StatDetails {
			Id = "Sacred Heart",
			Stats = new List<StatProbability>
				{
				new StatProbability { Id=2, Probability=.01 },
				new StatProbability { Id=3, Probability=.01 },
				new StatProbability { Id=4, Probability=.01 },
				new StatProbability { Id=5, Probability=.01 },
				new StatProbability { Id=6, Probability=.01 },
				new StatProbability { Id=7, Probability=.01 }
		}
		}
	};
}