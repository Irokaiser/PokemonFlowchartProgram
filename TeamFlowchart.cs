[Serializable]
public class TeamFlowchart
{
    public List<string> Team { get; set; } = new List<string>();

    public List<Question> Questions { get; set; } = new List<Question>();

    public void Execute()
    {
        //Generate scoreboard obj
        var scoreboard = new Dictionary<string, int>();
        foreach (var member in Team)
        {
            scoreboard[member] = 0;
        }

        //Iterate through and ask each question
        int q = 1;
        foreach (var question in Questions)
        {
            Console.WriteLine(q + ") " + question.Query);

            string answer;
            do
            {
                Console.Write("[Y/N]: ");
                answer = Console.ReadLine().ToUpper();
            } while (answer != "Y" && answer != "N");

            //If yes, apply the scores to the scoreboard
            if (answer == "Y")
            {
                foreach (var score in question.Scoreboard)
                {
                    if (scoreboard.ContainsKey(score.Key))
                        scoreboard[score.Key] += score.Value;
                }
            }

            q++;
        }

        //Output results in order by score
        Console.WriteLine("Results:");
        var result = scoreboard.OrderByDescending(s => s.Value).ToDictionary(s => s.Key, s => s.Value);

        int i = 1;
        foreach (var pokemon in result)
        {
            Console.WriteLine(i + ") " + pokemon.Key + " - " + pokemon.Value);
            i++;
        }
    }
}