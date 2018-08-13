using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Zone1 = 25%
 * Zone2 = 14 + HR
 * Zone3 = 12%
 * Zone4 = 8% + HR
 * */
namespace JoesShipping
{
    class Program
    {

        public Program()
        {
        }

        static void Main(string[] args)
        {
            ItemPrice item = new ItemPrice();
            string zone = item.GetZone();
            Console.WriteLine("Price = "  + item.GetPrice(zone));
            Console.ReadLine();
        }

    }
}
