namespace DailyCodingProblem.Companies
{
    public static class Print
    {
        public static void ChallengeInfos(string title, string description)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(description);
        }
    }
}
