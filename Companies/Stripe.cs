using Newtonsoft.Json;
using System.ComponentModel;

namespace DailyCodingProblem.Companies
{
    public static class Stripe
    {
        public static void ProblemOne(int[] list)
        {
            #region Enunciado
            Print.ChallengeInfos("[STRIPE] DESAFIO 1:",
@"Dado um array de inteiros, ache o primeiro número positivo inteiro faltando em um tempo linear e espaço constante.
Em outras palavras, ache o menor número inteiro positivo que não exista no array
(o array pode conter números duplicados e negativos também).
Por exemplo, o input de [3, 4, -1, 1], deve retornar 2. O input de [1, 2, 0] deve retornar 3.");
            #endregion

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

            Console.WriteLine($"-> Input recebido: {JsonConvert.SerializeObject(list)}");
            Console.WriteLine($"-> Output obtido: {JsonConvert.SerializeObject(missingNum)}");
        }
    }
}
