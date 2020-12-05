using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFourChallenge
{
    abstract class Wine
    {
        static void Main(string[] args)
        { 
        }


        public string Name { get; set; }
        public string Type { get; set; }
        public string Region { get; set; }
        public decimal Cost { get; set; }

        public Wine() { }

        public Wine(string name, string type, string region, decimal cost)
        {
            Name = name;
            Type = type;
            Region = region;
            Cost = cost;
        }

        //-----------------Methods below----------------------//
        public void DisplayWineUnderTwentyDollars(Wine Brand)
        {
            Console.WriteLine($"{Brand.Name}, {Brand.Type}, {Brand.Region}, {Brand.Cost}");
        }
    }

    class Reds : Wine
    {
        public bool HasTannins { get; set; }
        public Reds() { }
        public Reds(bool hasTannins, string name, string type, string region, decimal cost)
            : base(name, type, region, cost)
        {
            HasTannins = hasTannins;
        }
    }

    class Whites : Wine
    {
        //----------This version of HasTannins is READ ONLY, I can not set a value to this, will always be FALSE//
        public bool HasTannins { get; } = false;
        public Whites() { }
        public Whites(string name, string type, string region, decimal cost)
            : base(name, type, region, cost)
        {
        }
    }

    class PinotNoir : Reds
    {
        public int YearMade { get; set; }
        public PinotNoir() { }
        public PinotNoir(int yearMade, string name, string type, string region, decimal cost, bool hasTannins)
            : base(hasTannins, name, type, region, cost)
        {
            YearMade = yearMade;
        }
    }
}


      