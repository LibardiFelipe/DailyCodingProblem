namespace DailyCodingProblem.Companies
{
    public static class Microsoft
    {
        public static string ProblemOneUrlToShortned(string url, ref List<Tuple<string, string>> shortnedUrls)
        {
            #region Enunciado
            Print.ChallengeInfos("[MICROSOFT] DESAFIO 1:",
@"Dado um URL, crie um encurtador transformando-o em seis caracteres alfanuméricos.
Crie também uma maneira de desencurta-los.");
            #endregion

            // Tuple item1 will stand for the URL and item2 for the shortned version of it
            var exists = shortnedUrls.FirstOrDefault(x => x.Item1.ToLower() == url.ToLower());
            if (exists is not null)
                return exists.Item2;

            var shortned = Guid.NewGuid().ToString("N")[..6];
            shortnedUrls.Add(new Tuple<string, string>(url.ToLower(), shortned));

            Console.WriteLine($"-> Input recebido: {url}");
            Console.WriteLine($"-> Output obtido: {shortned}");

            return shortned;
        }

        public static string ProblemOneShortnedToUrl(string shorned, ref List<Tuple<string, string>> shortnedUrls)
        {
            Console.WriteLine("Desencurtando...");

            var exists = shortnedUrls.FirstOrDefault(x => x.Item2 == shorned);
            if (exists is not null)
            {
                Console.WriteLine($"-> Input recebido: {shorned}");
                Console.WriteLine($"-> Output obtido: {exists.Item1}");

                return exists.Item1;
            }

            return string.Empty;
        }
    }
}
