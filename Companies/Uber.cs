using Newtonsoft.Json;
using System.Collections.Generic;

namespace DailyCodingProblem.Companies
{
    public static class Uber
    {
        public static void ProblemOne(int[] nums)
        {
            #region Enunciado
            Print.ChallengeInfos("[UBER] DESAFIO 1:",
@"Dado um array de inteiros, retorna um novo array em que cada elemento
(i) do novo array é o produto de todos os números do array original, exceto o i.
Por exemplo, se o input for [1, 2, 3, 4, 5], o output esperado será [120, 60, 40, 30, 24].
Se o input for [3, 2, 1], o output esperado será [2, 3, 6].");
            #endregion

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

            Console.WriteLine($"-> Input recebido: {JsonConvert.SerializeObject(nums)}");
            Console.WriteLine($"-> Output obtido: {JsonConvert.SerializeObject(result)}");
        }
    }
}
