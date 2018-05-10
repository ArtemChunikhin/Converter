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

        public Double ConvertValue(Double value)
        {


            return;
        }
    }

    internal class InputData
    {


        public void Input()
        {
            Console.Write("Enter USD to UAH: ");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
