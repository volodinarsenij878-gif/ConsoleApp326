using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program166
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Код валюты (USD, EUR, CNY, RUB): ");
            string? currency = Console.ReadLine()?.Trim().ToUpper();
            string fullName;

            switch (currency)
            {
                case "USD": fullName = "Доллар США"; break;
                case "EUR": fullName = "Евро"; break;
                case "CNY": fullName = "Китайский юань"; break;
                case "RUB": fullName = "Российский рубль"; break;
                default:
                    Console.WriteLine("Неизвестная валюта.");
                    return;
            }

            Console.WriteLine(fullName);
        }
    }
}