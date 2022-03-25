using System;
using upcasting.Models;
namespace upcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Exchange(Currency currency, double azn)
            {
                double result = 0;
                if (currency == Models.Currency_Enum.Usd)
                {
                    result = azn * 0.59;
                }
                if (currency == Models.Currency_Enum.Try)
                {
                    result = azn * 0.11;
                }
                if (currency == Models.Currency_Enum.Euro)
                {
                    result = azn * 0.5;
                }

                return result;
            }
            
            Console.WriteLine(Exchange(Currency_Enum.Try,5));
        }

        private static double Exchange(object euro, int v)
        {
            throw new NotImplementedException();
        }
    }
}
