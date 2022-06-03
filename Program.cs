using Newtonsoft.Json;

Console.WriteLine("Pokemon Team Flowchart Program");

string filename = "Team.json";
var flowchart = JsonConvert.DeserializeObject<TeamFlowchart>(File.ReadAllText(filename));

if (flowchart != null)
{
    flowchart.Execute();
}
else
{
    Console.WriteLine("Invalid team and questions defined in " + filename);
}