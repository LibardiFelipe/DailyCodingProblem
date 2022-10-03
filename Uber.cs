namespace DailyCodingProblem
{
    public static class Uber
    {
        public static int[] ProblemOne(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (j == i) continue;

                    if (result[i] == 0)
                    {
                        result[i] = nums[j] * nums[j + 1 == i ? j + 2 : j + 1];
                    }
                    else
                    {
                        if (i == result.Length - 1 && j == nums.Length - 2)
                            continue;

                        result[i] *= nums[j + 1 == i && j + 2 <= nums.Length - 1 ? j + 2 : j + 1];
                    }
                }
            }

            return result;
        }
    }
}
