using DailyCodingProblem.Companies;

namespace DailyCodingProblem
{
    internal class Program
    {
        protected static void Main(string[] args)
        {
            #region Vars
            var shortnetUrls = new List<Tuple<string, string>>(); 
            #endregion

            #region Google
            Google.ProblemOne(new List<int> { 10, 15, 3, 7 }, 17);
            Console.WriteLine();
            #endregion

            #region Uber
            Uber.ProblemOne(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine();
            #endregion

            #region Stripe
            Stripe.ProblemOne(new int[] { 3, 4, -1, 1 });
            Console.WriteLine();
            #endregion

            #region Microsoft
            var shortUrl = Companies.Microsoft.ProblemOneUrlToShortned("www.google.com.br", ref shortnetUrls);
            Companies.Microsoft.ProblemOneShortnedToUrl(shortUrl, ref shortnetUrls);
            #endregion

            Console.ReadLine();
        }
    }
}