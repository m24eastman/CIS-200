// 5272456
// cis 200-50
// prog 1a
// 09/27/2021
// this class is derived from Package class and calculates cost based on package dimensions, weight, and distance traveled
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class GroundPackage : Package
    {
        // backing field
        public readonly int distance; // read only integer for distance

        //there is no pre condition
        // post condition is groundpackage made 
        public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) : base (originAddress, destAddress, length, width, height, weight)
        {}
        // there is no pre condition
        // post condition is math for distance is done and value returned.
        private int ZoneDistance
        {
            get
            { return Math.Abs((OriginAddress.Zip/10000)-(DestinationAddress.Zip/10000));
            }
        }
        // there is no pre condition
        // post condition is cost is returned and cost is calculated
        public override decimal CalcCost()
        {
            double cost = 0.15*(Length + Width + Height)+0.7*(ZoneDistance + 1)*(Weight);
            return (decimal)cost;
        }
        // there is no pre condition
        // post condition is string returned, values are displayed on new line, values are in money format.
        public override string ToString()
        {
            return ($"Width:{Width}" +
                $" Length:{Length}" +
                $" Height{Height}" +
                $" Weight:{Weight}" +
                $" Zone Distance:{ZoneDistance}" +
                $" Cost:{CalcCost(): C}");
        }
    }
}
