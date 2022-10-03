namespace DailyCodingProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Este desafio foi proposto recentemente pela Google.
             * Dado uma lista de números e um número (k), retorna true caso dois números dessa lista somados seja igual à k.
             * Por exemplo, dado [10, 15, 3, 7] e k = 17, retorna true, pois 10 + 7 é 17.
             */
            var list = new List<int> { 10, 15, 3, 7 };
            Console.WriteLine(Google.ProblemOne(list, 17));

            /*
             * Este desafio foi proposto pela Uber.
             * Dado um array de inteiros, retorna um novo array em que cada elemento
             * (i) do novo array é o produto de todos os números do array original, exceto o do i.
             * Por exemplo, se o input for [1, 2, 3, 4, 5], o output esperado será [120, 60, 40, 30, 24].
             * Se o input for [3, 2, 1], o output esperado será [2, 3, 6].
             */
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("{ " + $"{string.Join(", ", Uber.ProblemOne(nums))}" + " }");

            Console.ReadLine();
        }
    }
}