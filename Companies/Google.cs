namespace DailyCodingProblem.Companies
{
    public static class Google
    {
        public static bool ProblemOne(List<int> list, int k)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    var sum = list[i] + list[j + 1];
                    if (sum == k)
                        return true;
                }
            }

            return false;
        }
    }
}
