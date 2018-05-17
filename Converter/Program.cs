using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Converter
    {
        private readonly Double usd;
        private readonly Double eur;
        private readonly Double rub;

        public Converter()
        { }
        public Converter(Double usd, Double eur, Double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public Double ConvertUAH(Double value, Int32 convertTo)
        {
            switch (convertTo)
            {
                case 1:
                    throw new Exception();
                case 2:
                    return value * eur;
                case 3:
                    return value * usd;
                case 4:
                    return value * rub;
            }
            throw new Exception();
        }
        public Double ConvertUSD(Double value, Int32 convertTo)
        {
            switch (convertTo)
            {
                case 1:
                    Double usdToUah = 1 / usd;
                    return value * usdToUah;
                case 2:
                    Double usdToEur = (value * usd) / eur;
                    return usdToEur;
                case 3:
                    throw new Exception();
                case 4:
                    Double usdToRub = (value * usd) / rub;
                    return usdToRub;
            }
            throw new Exception();

        }
    }

    internal class UserInterface
    {
        private Int32 intCheck;
        private Int32 a;
        public Int32 Input(out Int32 currency, out Int32 convertToCurrency)
        {
            Console.Write("Enter value: ");
            if (Int32.TryParse(Console.ReadLine(), out intCheck))
            {
                Int32 valueMoney = intCheck;
                Console.WriteLine("UAH - 1| EUR - 2| USD - 3| RUB - 4");
                if (Int32.TryParse(Console.ReadLine(), out intCheck))
                {
                    currency = intCheck;
                    Console.WriteLine("Will convert to: UAH - 1| EUR - 2| USD - 3| RUB - 4");
                    if (Int32.TryParse(Console.ReadLine(), out intCheck))
                    {
                        convertToCurrency = intCheck;
                        return valueMoney;

                    }
                }
            }
            throw new Exception();
        }
    }
        class Program
        {
            private static Int32 valueMoney;
            private static Int32 currency;
            private static Int32 convertToCurrency;
            static void Main(string[] args)
            {
                UserInterface ui = new UserInterface();
                valueMoney = ui.Input(out currency, out convertToCurrency);
            Converter converter = new Converter();
            switch (currency)
            {
                case 1:
                    converter.ConvertUAH(valueMoney, convertToCurrency);
                    break;
            }

                
            }
        }
    }