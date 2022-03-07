using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._4
{
    //class for the beverages 
    public enum CountryofOrig
    {
        Brazil,
        Columbia,
        Vietnam

    }
    public abstract class Beverage
    {
        public abstract int DrinkId { get; set; }
       public abstract string Name { get; set; }

    }
    public class Coffee : Beverage
    {
        override public int DrinkId { get; set;}
        override public string Name { get; set; }

        public string HotorIced { get; set; }
        public CountryofOrig Country { get; set;}

    }

}
