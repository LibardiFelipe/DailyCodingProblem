using Newtonsoft.Json;

namespace DailyCodingProblem.Companies
{
    public static class Google
    {
        public static void ProblemOne(List<int> list, int k)
        {
            #region Enunciado
            Print.ChallengeInfos("[GOOGLE] DESAFIO 1:",
@"Dado uma lista de números e um número (k), retorna true caso dois números dessa lista somados seja igual à k.
Por exemplo, dado [10, 15, 3, 7] e k = 17, retorna true, pois 10 + 7 é 17.");
            #endregion

            bool contains = false;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    var sum = list[i] + list[j + 1];
                    if (sum == k)
                    {
                        contains = true;
                        break;
                    }
                }

                if (contains) break;
            }

            Console.WriteLine($"-> Input recebido: {JsonConvert.SerializeObject(list)}, K={k}");
            Console.WriteLine($"-> Output obtido: {JsonConvert.SerializeObject(contains)}");
        }
    }
}
