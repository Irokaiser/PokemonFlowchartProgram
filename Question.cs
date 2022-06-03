[Serializable]
public class Question
{
    public string Query { get; set; }

    public Dictionary<string, int> Scoreboard { get; set; } = new Dictionary<string, int>();

    public Question(string query, Dictionary<string, int> scoreboard)
    {
        Query = query;
        Scoreboard = scoreboard;
    }
}