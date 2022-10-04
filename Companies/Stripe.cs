namespace DailyCodingProblem.Companies
{
    public static class Stripe
    {
        public static int ProblemOne(int[] list)
        {
            var ord = list.OrderBy(x => x).ToArray();

            int missingNum = 0;
            foreach(var num in ord)
            {
                if (num > 0)
                {
                    var nextNumber = num + 1;
                    if (!ord.Contains(nextNumber))
                    {
                        missingNum = nextNumber;
                        break;
                    }
                }
            }

            return missingNum;
        }
    }
}
