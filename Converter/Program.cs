using System;

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
                    return value / eur;
                case 3:
                    return value / usd;
                case 4:
                    return value / rub;
            }
            throw new Exception();
        }
        public Double ConvertUSD(Double value, Int32 convertTo)
        {
            switch (convertTo)
            {
                case 1:
                    return value * usd;
                case 2:
                    return (value * usd) / eur;
                case 3:
                    throw new Exception();
                case 4:
                    return (value * usd) / rub;
            }
            throw new Exception();

        }
        public Double ConvertEUR(Double value, Int32 convertTo)
        {
            switch (convertTo)
            {
                case 1:
                    return value * eur;
                case 2:
                    throw new Exception();
                case 3:
                    return (value * eur) / usd;
                case 4:
                    return (value * eur) / rub;
            }
            throw new Exception();
        }
        public Double ConvertRUB(Double value, Int32 convertTo)
        {
            switch (convertTo)
            {
                case 1:
                    return value * rub;
                case 2:
                    return (value * rub) / usd;
                case 3:
                    return (value * rub) / usd;
                case 4:
                    throw new Exception();
            }
            throw new Exception();
        }
    }

    internal class UserInterface
    {
        private Int32 intCheck;
        private Double doubleCheck;
        public Int32 Input(out Int32 currency, out Int32 convertToCurrency,
                            out Double usd, out Double eur, out Double rub)
        {
            Console.Write("Enter currency usd to uah: ");
            if (Double.TryParse(Console.ReadLine(), out doubleCheck))
            {
                usd = doubleCheck;
                Console.Write("Enter currency eur to uah: ");
                if (Double.TryParse(Console.ReadLine(), out doubleCheck))
                {
                    eur = doubleCheck;
                    Console.Write("Enter currency rub to uah: ");
                    if (Double.TryParse(Console.ReadLine(), out doubleCheck))
                    {
                        rub = doubleCheck;
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
                    }
                }

            }
            throw new Exception();
        }
        public void Output(Double convertedValue)
        {
            Console.WriteLine("result {0}", convertedValue);
        }
    }
    class Program
    {
        private static Int32 valueMoney;
        private static Int32 currency;
        private static Int32 convertToCurrency;
        private static Double usd;
        private static Double eur;
        private static Double rub;

        static void Main(string[] args)
        {
            try
            {

                UserInterface ui = new UserInterface();
                valueMoney = ui.Input(out currency, out convertToCurrency, out usd, out eur, out rub);
                Converter converter = new Converter(usd, eur, rub);
                switch (currency)
                {
                    case 1:
                        ui.Output(converter.ConvertUAH(valueMoney, convertToCurrency));
                        break;
                    case 2:
                        ui.Output(converter.ConvertEUR(valueMoney, convertToCurrency));
                        break;
                    case 3:
                        ui.Output(converter.ConvertUSD(valueMoney, convertToCurrency));
                        break;
                    case 4:
                        ui.Output(converter.ConvertRUB(valueMoney, convertToCurrency));
                        break;
                    default:
                        break;
                }
            }
            catch (Exception) { }
        }
    }
}