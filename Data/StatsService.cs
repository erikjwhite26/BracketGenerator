using BlazorApp.Entities;
namespace BlazorApp.Data;
class StatsService
{
//https://mcubed.net/ncaab/seeds.shtml
	public List<StatDetails> HistoricStats { get; } = new List<StatDetails>{
		new StatDetails{
			Id = "1",
			Stats = new List<StatProbability>{
				new StatProbability { Id=1, Probability=.50 },
				new StatProbability(){ Id=2, Probability=.55 },
				new StatProbability(){ Id=3, Probability=.63 },
				new StatProbability(){ Id=4, Probability=.71 },
				new StatProbability(){ Id=5, Probability=.83 },
				new StatProbability(){ Id=6, Probability=.71 },
				new StatProbability(){ Id=7, Probability=.86 },
				new StatProbability(){ Id=8, Probability=.79 },
				new StatProbability(){ Id=9, Probability=.91 },
				new StatProbability(){ Id=10, Probability=.88 },
				new StatProbability(){ Id=11, Probability=.56 },
				new StatProbability(){ Id=12, Probability=.99 },
				new StatProbability(){ Id=13, Probability=.99 },
				new StatProbability(){ Id=14, Probability=.99 },
				new StatProbability(){ Id=15, Probability=.99 },
				new StatProbability(){ Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id = "2",
			Stats = new List<StatProbability>{
				new StatProbability{ Id=1, Probability=45 },
				new StatProbability{ Id=2, Probability=.50 },
				new StatProbability{ Id=3, Probability=.61 },
				new StatProbability{ Id=4, Probability=.50 },
				new StatProbability{ Id=5, Probability=.29 },
				new StatProbability{ Id=6, Probability=.72 },
				new StatProbability{ Id=7, Probability=.70 },
				new StatProbability{ Id=8, Probability=.40 },
				new StatProbability{ Id=9, Probability=.67 },
				new StatProbability{ Id=10, Probability=.64 },
				new StatProbability{ Id=11, Probability=.84 },
				new StatProbability{ Id=12, Probability=.99 },
				new StatProbability{ Id=13, Probability=.99 },
				new StatProbability{ Id=14, Probability=.99 },
				new StatProbability{ Id=15, Probability=.93 },
				new StatProbability{ Id=16, Probability=.99 }
			}
		},
		new StatDetails{
			Id="3",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=37 },
				new StatProbability{ Id=2, Probability=39 },
				new StatProbability{ Id=3, Probability=50 },
				new StatProbability{ Id=4, Probability=63 },
				new StatProbability{ Id=5, Probability=50 },
				new StatProbability{ Id=6, Probability=58 },
				new StatProbability{ Id=7, Probability=61 },
				new StatProbability{ Id=8, Probability=99 },
				new StatProbability{ Id=9, Probability=99 },
				new StatProbability{ Id=10, Probability=69 },
				new StatProbability{ Id=11, Probability=66 },
				new StatProbability{ Id=12, Probability=99 },
				new StatProbability{ Id=13, Probability=99 },
				new StatProbability{ Id=14, Probability=85 },
				new StatProbability{ Id=15, Probability=67 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="4",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=29 },
				new StatProbability{ Id=2, Probability=50 },
				new StatProbability{ Id=3, Probability=37 },
				new StatProbability{ Id=4, Probability=50 },
				new StatProbability{ Id=5, Probability=56 },
				new StatProbability{ Id=6, Probability=33 },
				new StatProbability{ Id=7, Probability=33 },
				new StatProbability{ Id=8, Probability=33 },
				new StatProbability{ Id=9, Probability=50 },
				new StatProbability{ Id=10, Probability=99 },
				new StatProbability{ Id=11, Probability=99 },
				new StatProbability{ Id=12, Probability=71 },
				new StatProbability{ Id=13, Probability=79 },
				new StatProbability{ Id=14, Probability=99 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="5",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=17 },
				new StatProbability{ Id=2, Probability=71 },
				new StatProbability{ Id=3, Probability=50 },
				new StatProbability{ Id=4, Probability=44 },
				new StatProbability{ Id=5, Probability=50 },
				new StatProbability{ Id=6, Probability=99 },
				new StatProbability{ Id=7, Probability=99 },
				new StatProbability{ Id=8, Probability=25 },
				new StatProbability{ Id=9, Probability=25 },
				new StatProbability{ Id=10, Probability=99 },
				new StatProbability{ Id=11, Probability=99 },
				new StatProbability{ Id=12, Probability=67 },
				new StatProbability{ Id=13, Probability=84 },
				new StatProbability{ Id=14, Probability=99 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="6",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=29 },
				new StatProbability{ Id=2, Probability=28 },
				new StatProbability{ Id=3, Probability=42 },
				new StatProbability{ Id=4, Probability=67 },
				new StatProbability{ Id=5, Probability=01 },
				new StatProbability{ Id=6, Probability=50 },
				new StatProbability{ Id=7, Probability=67 },
				new StatProbability{ Id=8, Probability=25 },
				new StatProbability{ Id=9, Probability=99 },
				new StatProbability{ Id=10, Probability=60 },
				new StatProbability{ Id=11, Probability=63 },
				new StatProbability{ Id=12, Probability=99 },
				new StatProbability{ Id=13, Probability=99 },
				new StatProbability{ Id=14, Probability=88 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="7",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=14 },
				new StatProbability{ Id=2, Probability=30 },
				new StatProbability{ Id=3, Probability=39 },
				new StatProbability{ Id=4, Probability=67 },
				new StatProbability{ Id=5, Probability=01 },
				new StatProbability{ Id=6, Probability=33 },
				new StatProbability{ Id=7, Probability=50 },
				new StatProbability{ Id=8, Probability=50 },
				new StatProbability{ Id=9, Probability=99 },
				new StatProbability{ Id=10, Probability=60 },
				new StatProbability{ Id=11, Probability=01 },
				new StatProbability{ Id=12, Probability=99 },
				new StatProbability{ Id=13, Probability=99 },
				new StatProbability{ Id=14, Probability=99 },
				new StatProbability{ Id=15, Probability=40 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="8",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=21 },
				new StatProbability{ Id=2, Probability=60 },
				new StatProbability{ Id=3, Probability=01 },
				new StatProbability{ Id=4, Probability=67 },
				new StatProbability{ Id=5, Probability=75 },
				new StatProbability{ Id=6, Probability=75 },
				new StatProbability{ Id=7, Probability=50 },
				new StatProbability{ Id=8, Probability=50 },
				new StatProbability{ Id=9, Probability=51 },
				new StatProbability{ Id=10, Probability=99 },
				new StatProbability{ Id=11, Probability=99 },
				new StatProbability{ Id=12, Probability=01 },
				new StatProbability{ Id=13, Probability=99 },
				new StatProbability{ Id=14, Probability=99 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="9",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=09 },
				new StatProbability{ Id=2, Probability=33 },
				new StatProbability{ Id=3, Probability=01 },
				new StatProbability{ Id=4, Probability=50 },
				new StatProbability{ Id=5, Probability=75 },
				new StatProbability{ Id=6, Probability=01 },
				new StatProbability{ Id=7, Probability=01 },
				new StatProbability{ Id=8, Probability=49 },
				new StatProbability{ Id=9, Probability=50 },
				new StatProbability{ Id=10, Probability=99 },
				new StatProbability{ Id=11, Probability=01 },
				new StatProbability{ Id=12, Probability=99 },
				new StatProbability{ Id=13, Probability=99 },
				new StatProbability{ Id=14, Probability=99 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="10",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=12 },
				new StatProbability{ Id=2, Probability=36 },
				new StatProbability{ Id=3, Probability=31 },
				new StatProbability{ Id=4, Probability=01 },
				new StatProbability{ Id=5, Probability=01 },
				new StatProbability{ Id=6, Probability=40 },
				new StatProbability{ Id=7, Probability=40 },
				new StatProbability{ Id=8, Probability=01 },
				new StatProbability{ Id=9, Probability=01 },
				new StatProbability{ Id=10, Probability=50 },
				new StatProbability{ Id=11, Probability=50 },
				new StatProbability{ Id=12, Probability=99 },
				new StatProbability{ Id=13, Probability=99 },
				new StatProbability{ Id=14, Probability=99 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="11",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=44 },
				new StatProbability{ Id=2, Probability=16 },
				new StatProbability{ Id=3, Probability=34 },
				new StatProbability{ Id=4, Probability=01 },
				new StatProbability{ Id=5, Probability=01 },
				new StatProbability{ Id=6, Probability=37 },
				new StatProbability{ Id=7, Probability=99 },
				new StatProbability{ Id=8, Probability=01 },
				new StatProbability{ Id=9, Probability=99 },
				new StatProbability{ Id=10, Probability=50 },
				new StatProbability{ Id=11, Probability=50 },
				new StatProbability{ Id=12, Probability=99 },
				new StatProbability{ Id=13, Probability=99 },
				new StatProbability{ Id=14, Probability=99 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="12",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=01 },
				new StatProbability{ Id=2, Probability=01 },
				new StatProbability{ Id=3, Probability=01 },
				new StatProbability{ Id=4, Probability=29 },
				new StatProbability{ Id=5, Probability=33 },
				new StatProbability{ Id=6, Probability=01 },
				new StatProbability{ Id=7, Probability=01 },
				new StatProbability{ Id=8, Probability=99 },
				new StatProbability{ Id=9, Probability=01 },
				new StatProbability{ Id=10, Probability=01 },
				new StatProbability{ Id=11, Probability=01 },
				new StatProbability{ Id=12, Probability=50 },
				new StatProbability{ Id=13, Probability=75 },
				new StatProbability{ Id=14, Probability=99 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="13",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=01 },
				new StatProbability{ Id=2, Probability=01 },
				new StatProbability{ Id=3, Probability=01 },
				new StatProbability{ Id=4, Probability=21 },
				new StatProbability{ Id=5, Probability=16 },
				new StatProbability{ Id=6, Probability=01 },
				new StatProbability{ Id=7, Probability=01 },
				new StatProbability{ Id=8, Probability=01 },
				new StatProbability{ Id=9, Probability=01 },
				new StatProbability{ Id=10, Probability=01 },
				new StatProbability{ Id=11, Probability=01 },
				new StatProbability{ Id=12, Probability=25 },
				new StatProbability{ Id=13, Probability=50 },
				new StatProbability{ Id=14, Probability=99 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="14",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=01 },
				new StatProbability{ Id=2, Probability=01 },
				new StatProbability{ Id=3, Probability=15 },
				new StatProbability{ Id=4, Probability=01 },
				new StatProbability{ Id=5, Probability=01 },
				new StatProbability{ Id=6, Probability=12 },
				new StatProbability{ Id=7, Probability=01 },
				new StatProbability{ Id=8, Probability=01 },
				new StatProbability{ Id=9, Probability=01 },
				new StatProbability{ Id=10, Probability=01 },
				new StatProbability{ Id=11, Probability=01 },
				new StatProbability{ Id=12, Probability=01 },
				new StatProbability{ Id=13, Probability=01 },
				new StatProbability{ Id=14, Probability=50 },
				new StatProbability{ Id=15, Probability=99 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="15",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=01 },
				new StatProbability{ Id=2, Probability=07 },
				new StatProbability{ Id=3, Probability=33 },
				new StatProbability{ Id=4, Probability=01 },
				new StatProbability{ Id=5, Probability=01 },
				new StatProbability{ Id=6, Probability=01 },
				new StatProbability{ Id=7, Probability=60 },
				new StatProbability{ Id=8, Probability=01 },
				new StatProbability{ Id=9, Probability=01 },
				new StatProbability{ Id=10, Probability=01 },
				new StatProbability{ Id=11, Probability=01 },
				new StatProbability{ Id=12, Probability=01 },
				new StatProbability{ Id=13, Probability=01 },
				new StatProbability{ Id=14, Probability=01 },
				new StatProbability{ Id=15, Probability=50 },
				new StatProbability{ Id=16, Probability=99 }
			}
		},
		new StatDetails{
			Id="16",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=1, Probability=01 },
				new StatProbability{ Id=2, Probability=01 },
				new StatProbability{ Id=3, Probability=01 },
				new StatProbability{ Id=4, Probability=01 },
				new StatProbability{ Id=5, Probability=01 },
				new StatProbability{ Id=6, Probability=01 },
				new StatProbability{ Id=7, Probability=01 },
				new StatProbability{ Id=8, Probability=01 },
				new StatProbability{ Id=9, Probability=01 },
				new StatProbability{ Id=10, Probability=01 },
				new StatProbability{ Id=11, Probability=01 },
				new StatProbability{ Id=12, Probability=01 },
				new StatProbability{ Id=13, Probability=01 },
				new StatProbability{ Id=14, Probability=01 },
				new StatProbability{ Id=15, Probability=01 },
				new StatProbability{ Id=16, Probability=50 }
			}
		}
	};

	public List<StatDetails> FiveThirtyEightStats { get; } = new List<StatDetails>
	{
		new StatDetails {
			Id = "Houston",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.97 },
				new StatProbability{ Id=3, Probability=.76 },
				new StatProbability{ Id=4, Probability=.62 },
				new StatProbability{ Id=5, Probability=.44 },
				new StatProbability{ Id=6, Probability=.34 },
				new StatProbability{ Id=7, Probability=.25 }
			}
		},
		new StatDetails {
			Id = "Alabama",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.99 },
				new StatProbability{ Id=3, Probability=.81 },
				new StatProbability{ Id=4, Probability=.64 },
				new StatProbability{ Id=5, Probability=.44 },
				new StatProbability{ Id=6, Probability=.29 },
				new StatProbability{ Id=7, Probability=.15 }
			}
		},
		new StatDetails {
			Id = "Texas",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.92 },
				new StatProbability{ Id=3, Probability=.64 },
				new StatProbability{ Id=4, Probability=.45 },
				new StatProbability{ Id=5, Probability=.21 },
				new StatProbability{ Id=6, Probability=.13 },
				new StatProbability{ Id=7, Probability=.08 }
			}
		},
		new StatDetails {
			Id = "Purdue",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.99 },
				new StatProbability{ Id=3, Probability=.72 },
				new StatProbability{ Id=4, Probability=.42 },
				new StatProbability{ Id=5, Probability=.26 },
				new StatProbability{ Id=6, Probability=.13 },
				new StatProbability{ Id=7, Probability=.05 }
			}
		},
		new StatDetails {
			Id = "Kansas",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.98 },
				new StatProbability{ Id=3, Probability=.66 },
				new StatProbability{ Id=4, Probability=.39 },
				new StatProbability{ Id=5, Probability=.20 },
				new StatProbability{ Id=6, Probability=.09 },
				new StatProbability{ Id=7, Probability=.05 }
			}
		},
		new StatDetails {
			Id = "Gonzaga",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.92 },
				new StatProbability{ Id=3, Probability=.63 },
				new StatProbability{ Id=4, Probability=.38 },
				new StatProbability{ Id=5, Probability=.22 },
				new StatProbability{ Id=6, Probability=.09 },
				new StatProbability{ Id=7, Probability=.04 }
			}
		},
		new StatDetails {
			Id = "Arizona",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.94 },
				new StatProbability{ Id=3, Probability=.68 },
				new StatProbability{ Id=4, Probability=.35 },
				new StatProbability{ Id=5, Probability=.15 },
				new StatProbability{ Id=6, Probability=.09 },
				new StatProbability{ Id=7, Probability=.04 }
			}
		},
		new StatDetails {
			Id = "UCLA",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.95 },
				new StatProbability{ Id=3, Probability=.69 },
				new StatProbability{ Id=4, Probability=.37 },
				new StatProbability{ Id=5, Probability=.21 },
				new StatProbability{ Id=6, Probability=.07 },
				new StatProbability{ Id=7, Probability=.03 }
			}
		},
		new StatDetails {
			Id = "UConn",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.85 },
				new StatProbability{ Id=3, Probability=.65 },
				new StatProbability{ Id=4, Probability=.32 },
				new StatProbability{ Id=5, Probability=.15 },
				new StatProbability{ Id=6, Probability=.06 },
				new StatProbability{ Id=7, Probability=.03 }
			}
		},
		new StatDetails {
			Id = "Marquette",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.89 },
				new StatProbability{ Id=3, Probability=.58 },
				new StatProbability{ Id=4, Probability=.34 },
				new StatProbability{ Id=5, Probability=.16 },
				new StatProbability{ Id=6, Probability=.07 },
				new StatProbability{ Id=7, Probability=.03 }
			}
		},
		new StatDetails {
			Id = "Baylor",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.89 },
				new StatProbability{ Id=3, Probability=.45 },
				new StatProbability{ Id=4, Probability=.24 },
				new StatProbability{ Id=5, Probability=.10 },
				new StatProbability{ Id=6, Probability=.06 },
				new StatProbability{ Id=7, Probability=.03 }
			}
		},
		new StatDetails {
			Id = "Creighton",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.78 },
				new StatProbability{ Id=3, Probability=.46 },
				new StatProbability{ Id=4, Probability=.26 },
				new StatProbability{ Id=5, Probability=.11 },
				new StatProbability{ Id=6, Probability=.06 },
				new StatProbability{ Id=7, Probability=.02 }
			}
		},
		new StatDetails {
			Id = "Duke",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.82 },
				new StatProbability{ Id=3, Probability=.46 },
				new StatProbability{ Id=4, Probability=.23 },
				new StatProbability{ Id=5, Probability=.13 },
				new StatProbability{ Id=6, Probability=.06 },
				new StatProbability{ Id=7, Probability=.02 }
			}
		},
		new StatDetails {
			Id = "Tennessee",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.87 },
				new StatProbability{ Id=3, Probability=.46 },
				new StatProbability{ Id=4, Probability=.22 },
				new StatProbability{ Id=5, Probability=.12 },
				new StatProbability{ Id=6, Probability=.05 },
				new StatProbability{ Id=7, Probability=.02 }
			}
		},
		new StatDetails {
			Id = "Kentucky",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.67 },
				new StatProbability{ Id=3, Probability=.45 },
				new StatProbability{ Id=4, Probability=.23 },
				new StatProbability{ Id=5, Probability=.10 },
				new StatProbability{ Id=6, Probability=.04 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Texas A&M",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.63 },
				new StatProbability{ Id=3, Probability=.24 },
				new StatProbability{ Id=4, Probability=.14 },
				new StatProbability{ Id=5, Probability=.07 },
				new StatProbability{ Id=6, Probability=.03 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Indiana",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.74 },
				new StatProbability{ Id=3, Probability=.47 },
				new StatProbability{ Id=4, Probability=.14 },
				new StatProbability{ Id=5, Probability=.07 },
				new StatProbability{ Id=6, Probability=.03 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "TCU",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.68 },
				new StatProbability{ Id=3, Probability=.26 },
				new StatProbability{ Id=4, Probability=.12 },
				new StatProbability{ Id=5, Probability=.05 },
				new StatProbability{ Id=6, Probability=.02 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "San Diego St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.67 },
				new StatProbability{ Id=3, Probability=.39 },
				new StatProbability{ Id=4, Probability=.11 },
				new StatProbability{ Id=5, Probability=.05 },
				new StatProbability{ Id=6, Probability=.02 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Iowa St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.58 },
				new StatProbability{ Id=3, Probability=.31 },
				new StatProbability{ Id=4, Probability=.13 },
				new StatProbability{ Id=5, Probability=.05 },
				new StatProbability{ Id=6, Probability=.02 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Xavier",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.87 },
				new StatProbability{ Id=3, Probability=.46 },
				new StatProbability{ Id=4, Probability=.16 },
				new StatProbability{ Id=5, Probability=.05 },
				new StatProbability{ Id=6, Probability=.02 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Auburn",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.58 },
				new StatProbability{ Id=3, Probability=.15 },
				new StatProbability{ Id=4, Probability=.08 },
				new StatProbability{ Id=5, Probability=.04 },
				new StatProbability{ Id=6, Probability=.02 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Kansas St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.85 },
				new StatProbability{ Id=3, Probability=.35 },
				new StatProbability{ Id=4, Probability=.15 },
				new StatProbability{ Id=5, Probability=.05 },
				new StatProbability{ Id=6, Probability=.02 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Saint Mary\'s",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.60 },
				new StatProbability{ Id=3, Probability=.18 },
				new StatProbability{ Id=4, Probability=.09 },
				new StatProbability{ Id=5, Probability=.05 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Arkansas",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.52 },
				new StatProbability{ Id=3, Probability=.18 },
				new StatProbability{ Id=4, Probability=.09 },
				new StatProbability{ Id=5, Probability=.04 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Virginia",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.72 },
				new StatProbability{ Id=3, Probability=.37 },
				new StatProbability{ Id=4, Probability=.10 },
				new StatProbability{ Id=5, Probability=.05 },
				new StatProbability{ Id=6, Probability=.02 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Michigan St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.64 },
				new StatProbability{ Id=3, Probability=.27 },
				new StatProbability{ Id=4, Probability=.13 },
				new StatProbability{ Id=5, Probability=.05 },
				new StatProbability{ Id=6, Probability=.02 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Memphis",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.61 },
				new StatProbability{ Id=3, Probability=.19 },
				new StatProbability{ Id=4, Probability=.08 },
				new StatProbability{ Id=5, Probability=.04 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Iowa",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.42 },
				new StatProbability{ Id=3, Probability=.09 },
				new StatProbability{ Id=4, Probability=.05 },
				new StatProbability{ Id=5, Probability=.03 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Illinois",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.48 },
				new StatProbability{ Id=3, Probability=.16 },
				new StatProbability{ Id=4, Probability=.07 },
				new StatProbability{ Id=5, Probability=.03 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Maryland",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.51 },
				new StatProbability{ Id=3, Probability=.10 },
				new StatProbability{ Id=4, Probability=.06 },
				new StatProbability{ Id=5, Probability=.03 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "West Virginia",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.49 },
				new StatProbability{ Id=3, Probability=.09 },
				new StatProbability{ Id=4, Probability=.05 },
				new StatProbability{ Id=5, Probability=.03 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Miami",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.60 },
				new StatProbability{ Id=3, Probability=.27 },
				new StatProbability{ Id=4, Probability=.06 },
				new StatProbability{ Id=5, Probability=.02 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Utah St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.64 },
				new StatProbability{ Id=3, Probability=.22 },
				new StatProbability{ Id=4, Probability=.08 },
				new StatProbability{ Id=5, Probability=.02 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Providence",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.33 },
				new StatProbability{ Id=3, Probability=.18 },
				new StatProbability{ Id=4, Probability=.09 },
				new StatProbability{ Id=5, Probability=.04 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Boise St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.59 },
				new StatProbability{ Id=3, Probability=.19 },
				new StatProbability{ Id=4, Probability=.07 },
				new StatProbability{ Id=5, Probability=.03 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Mississippi St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.25 },
				new StatProbability{ Id=3, Probability=.13 },
				new StatProbability{ Id=4, Probability=.04 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Penn St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.37 },
				new StatProbability{ Id=3, Probability=.11 },
				new StatProbability{ Id=4, Probability=.05 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Florida Atlantic",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.39 },
				new StatProbability{ Id=3, Probability=.09 },
				new StatProbability{ Id=4, Probability=.04 },
				new StatProbability{ Id=5, Probability=.02 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "USC",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.36 },
				new StatProbability{ Id=3, Probability=.12 },
				new StatProbability{ Id=4, Probability=.05 },
				new StatProbability{ Id=5, Probability=.02 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Drake",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.40 },
				new StatProbability{ Id=3, Probability=.15 },
				new StatProbability{ Id=4, Probability=.03 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Northwestern",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.41 },
				new StatProbability{ Id=3, Probability=.11 },
				new StatProbability{ Id=4, Probability=.03 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Missouri",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.36 },
				new StatProbability{ Id=3, Probability=.09 },
				new StatProbability{ Id=4, Probability=.03 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "NC State",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.22 },
				new StatProbability{ Id=3, Probability=.07 },
				new StatProbability{ Id=4, Probability=.03 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "VCU",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.40 },
				new StatProbability{ Id=3, Probability=.10 },
				new StatProbability{ Id=4, Probability=.03 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Arizona St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.18 },
				new StatProbability{ Id=3, Probability=.05 },
				new StatProbability{ Id=4, Probability=.02 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Charleston",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.33 },
				new StatProbability{ Id=3, Probability=.14 },
				new StatProbability{ Id=4, Probability=.02 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Pittsburgh",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.17 },
				new StatProbability{ Id=3, Probability=.08 },
				new StatProbability{ Id=4, Probability=.02 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Kent St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.26 },
				new StatProbability{ Id=3, Probability=.11 },
				new StatProbability{ Id=4, Probability=.02 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Nevada",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.14 },
				new StatProbability{ Id=3, Probability=.03 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Oral Roberts",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.18 },
				new StatProbability{ Id=3, Probability=.05 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Furman",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.28 },
				new StatProbability{ Id=3, Probability=.09 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Iona",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.15 },
				new StatProbability{ Id=3, Probability=.07 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Louisiana",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.13 },
				new StatProbability{ Id=3, Probability=.03 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Vermont",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.11 },
				new StatProbability{ Id=3, Probability=.03 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Grand Canyon",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.08 },
				new StatProbability{ Id=3, Probability=.02 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Colgate",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.08 },
				new StatProbability{ Id=3, Probability=.02 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Montana St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.15 },
				new StatProbability{ Id=3, Probability=.02 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "UC Santa Barbara",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.11 },
				new StatProbability{ Id=3, Probability=.02 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Princeton",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.06 },
				new StatProbability{ Id=3, Probability=.01 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Kennesaw St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.13 },
				new StatProbability{ Id=3, Probability=.02 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "N Kentucky",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.03 },
				new StatProbability{ Id=3, Probability=.01 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "UNC Asheville",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.05 },
				new StatProbability{ Id=3, Probability=.01 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Texas A&MCC",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.01 },
				new StatProbability{ Id=3, Probability=.01 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "SE Missouri St",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.01 },
				new StatProbability{ Id=3, Probability=.01 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Howard",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.02 },
				new StatProbability{ Id=3, Probability=.01 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Texas Southern",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.01 },
				new StatProbability{ Id=3, Probability=.01 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		},
		new StatDetails {
			Id = "Farleigh Dickinson",
			Stats = new List<StatProbability>
			{
				new StatProbability{ Id=2, Probability=.01 },
				new StatProbability{ Id=3, Probability=.01 },
				new StatProbability{ Id=4, Probability=.01 },
				new StatProbability{ Id=5, Probability=.01 },
				new StatProbability{ Id=6, Probability=.01 },
				new StatProbability{ Id=7, Probability=.01 }
			}
		}
	};
}