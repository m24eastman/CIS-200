// 5272456
// cis 200-50
// prog 1a
// 09/27/2021
// this is an abstract class derived from package class. it will add methods to determine if package is large or heavy
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    // there is not pre condition
    // post condition is air package class is created as an abstract class, being derived from package class
    abstract class AirPackage:Package
    {
        // there is no pre condition
        // post condition is AirPackage class is created 
        public AirPackage(Address originAddress, Address destinationAddress, double length, double width, double height, double weight) : base(originAddress, destinationAddress, length, width, height, weight)
        {}

        // there is no pre condition
        // post condition is, bool shows true if package is at or over 75 lbs, and false if it is under 75 lbs
        public bool IsHeavy()
        {
            if (Weight>= 75)
                return true; else return false;
        }
        // there is no pre condition
        // post condition is bool shows true if package is at or over 100 inches in its dimensions, and false if under 100 inches
        public bool IsLarge()
        {
            if (Length + Width + Height>=100)
                return true; else return false;
        }
        // there is no pre condition
        // post condition is everything is on different lines and returned string with currency formatting
        public override string ToString()
        {
            return ($"Width:{Width}" +
                $" Length:{Length}" +
                $" Height{Height}" +
                $" Weight:{Weight}" +
                $" Cost:{CalcCost() :C}" +
                $" Weight Status: {IsHeavy()}" +
                $" Size Status: {IsLarge()}");
        }
    }
}