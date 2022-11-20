namespace CurrencyExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
        }
    }

    internal class Currency
    {
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }

        public Currency(string currencyCode)
        {
            CurrencyCode = currencyCode;
        }
        public Currency(string currencyCode, string currencyName)
        {
            CurrencyCode = currencyCode;
            CurrencyName = currencyName;
        }
    }


}

