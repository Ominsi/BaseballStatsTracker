var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

List<StatLines> stateLines = new List<StatLines>();
app.Run();

public record StatLines(int ID, string player, string team, int games, int atBats, int runs, int hits, int doubles, int triples, int homeRuns, int runsBattedIn, int stolenBases, int walks, float battingAverage, float slugging, float ops, float war, DateTime gameDate, int gameNumber = 0);
