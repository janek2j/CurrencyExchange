namespace CurrencyExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"CHF" };
            list.Add("PLN");
            list.Add("EUR");
            list.Add("USD");
            list.Add("JPY");

            list.Sort();

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
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

    internal class ExchangeTransaction
    {
        public string TransactionId { get; set; }
        public string TransactionType { get; set; }

        public string CurrencyFrom { get; set; }
        public string CurrencyTo { get; set; }

        public decimal ExchangeRate { get; set; }
        public string? TransactionDescription { get; set; }

        public decimal TransactionFee { get; set; }
        public decimal AmountFrom { get; set; }

        public decimal AmountTo { get; set; }

    }

}

