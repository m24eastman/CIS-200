// 5272456
// cis 200-50
// prog 1a
// 09/27/2021
// this class is derived from air package and is for packages that do not have express fee
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    // there is no pre condition
    // post condition is twodayairpackage obj is made
    class TwoDayAirPachage : AirPackage
    {
        // there is no pre condition
        // post condition is setting early or saver enum types for delivery
        public enum Delivery
        {
            Early, Saver
        }
        private Delivery delivery;
        public Delivery DeliveryType
        {
            // no pre condition
            // post condition is delivery is returned
            get
            { return delivery;}

// pre condition is that delivery must be early or saver
            // post cond is delivery has been set or error
            set
            {
                if (value == Delivery.Early || value == Delivery.Saver)
                {
                    delivery = value;
                }
                else throw new ArgumentOutOfRangeException($"{nameof(DeliveryType)} is invalid. Enter a valid delivery method.");
            }
        }
        // there is no pre condition
        // post cond is twodayairpackage is created
        public TwoDayAirPachage(Address originAddress, Address destinationAddress, double length, double width, double height, double weight, Delivery DeliveryType) : base(originAddress, destinationAddress, length, width, height, weight)
        {}

        // there is no  pre condition
        // post condition is final cost is calculated and returned
        public override decimal CalcCost()
        {
            double final;
            double baseCost =0.18*(Length + Width + Height)+0.2*(Weight);

            if (DeliveryType == Delivery.Saver) // if delivery is saver, 15% discount   
            { final = baseCost * 0.85; }
            else
            {
                final = baseCost;
            }
            return (decimal)final;
        }
    }
}