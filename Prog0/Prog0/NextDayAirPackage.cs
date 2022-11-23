// 5272456
// cis 200-50
// prog 1a
// 09/27/2021
// this class is derived from AirPackage and is concrete. It shows extra fees for the fast shipping for next day
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    // there is no pre condition
    // post condition is NextDayAirPackage is made from AirPackage
    class NextDayAirPackage:AirPackage
    {
        // backing fields
        public readonly decimal Express_Fee;

        // there is no pre condition
        // post condition is NextDayAirPackage is created
        public NextDayAirPackage(Address originAddress, Address destinationAddress, double length, double width, double height, double weight, decimal expressFee) : base(originAddress, destinationAddress, length, width, height, weight)
        {}
        // there is no pre condition
        // post condition is fee is returned
        public decimal ExpressFee
        {
            get
            {return Express_Fee;}
        }
        // there is no pre condition
        // post condition is cost is calculated and returned
        public override decimal CalcCost()
        {
            double basecost = 0.35 * (Length + Width + Height) + 0.25 * (Weight) + (double)ExpressFee;
            if (IsHeavy() == true)
            {
                basecost = basecost + 0.2 * (Weight);
            }
            if (IsLarge() == true)
            {
                basecost = basecost + 0.22 * (Length + Width + Height);
            }
            return (decimal)basecost;
        }
        // there is no pre condition
        // post condition is string is returned, values are on different lines, and is in currency format
        public override string ToString()
        {
            return ($"Width:{Width}" +
                $" Length:{Length}" +
                $" Height:{Height}" +
                $" Weight{Weight}" +
                $" Express Fee: {ExpressFee}" +
                $" Cost: {CalcCost():C}");
        }
    }
}
