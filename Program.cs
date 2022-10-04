using DailyCodingProblem.Companies;

namespace DailyCodingProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Google.ProblemOne(new List<int> { 10, 15, 3, 7 }, 17);
            Console.WriteLine();

            Uber.ProblemOne(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine();
            
            Stripe.ProblemOne(new int[] { 3, 4, -1, 1 });
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}