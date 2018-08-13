using System;

namespace JoesShipping
{
    public class ItemPrice
    {
        private double price;
        private string zone;
        delegate int MyDelegate(String arg1);
        readonly int HR = 5;
        readonly int zone1Price = 25;
        readonly int zone2Price = 14;
        readonly int zone3Price = 12;
        readonly int zone4Price = 8;

        public int HR1 => HR;
        public double Zone1Price
        {
            get
            {
                return zone1Price;
            }
        }

        public double Zone2Price
        {
            get
            {
                return zone2Price;
            }
        }

        public double Zone3Price
        {
            get
            {
                return zone3Price;
            }
        }

        public double Zone4Price
        {
            get
            {
                return zone4Price;
            }
        }

        //private MyDelegate GetPrice1 { get => GetPrice; set => GetPrice = value; }

        public ItemPrice()
        {
            Console.WriteLine("What is base price?");
            string answer = Console.ReadLine();
            Double.TryParse(answer,out double result);
            this.price = result;
        }

        public string GetZone()
        {
            Console.WriteLine("What Zone do you want to ship to?");
            this.zone = Console.ReadLine();
            return zone;
        }

        MyDelegate f = delegate (int arg1, int arg2) {
            return (arg1 + arg2).ToString();
        };
        Console.WriteLine("The number is: " + f(10,20));

        public double GetPrice (string zone) 
        { 
            switch (zone)
            {
                case "Zone1":
                    price = this.price * zone1Price;
                    break;

                case "Zone2":
                    price = this.price * (zone2Price + HR);
                    break;

                case "Zone3":
                    price = this.price * zone3Price;
                    break;

                case "Zone4":
                    price = this.price * (zone4Price + HR);
                    break;

                default:
                    price = 0;
                    break;
            }
            return price;           
        }
    }
}