//E4182
// Program #: 0
// Due Date: 9/7/2020
// Section 76
/* Letter Class description: The Letter class manages all the letters in this program. It validates and stroes the letters fixed costs, 
 * Calculates the final cost, and outputs the result onto the console.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Prog0
{
    class Letter : Parcel // Letter "Is-a" Parcel
    {
        private decimal _fixedCost; // Stroes the fixed cost of the letters


        // Precondition: The Address variables have already been validated and the fixed cost value is >= 0
        // Postcondition: The Letter class has been created with the values set with the parameters
        public Letter(Address OriginAddress, Address DestAddress, decimal fixedCost) : base(OriginAddress, DestAddress)
        {
            //sending parameter to properties for validation
            FixedCost = fixedCost;
        }

        private decimal FixedCost
        {

            // Precondition: None
            // Postcondition: Fixed cost is returned
            get
            {
                return _fixedCost;
            }

            set
            {
                // Precondition: Fixed cost is >= 0
                // Postcondition: The vlaue for fixed cost is set or an error message is shown
                if (value >= 0)
                {
                    _fixedCost = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(nameof(FixedCost), value, $"Sorry, {nameof(FixedCost)} is invalid.");
                }
            }
        }

        // This method calculates the cost by using the fixed cost which is passed in
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        // This method returns a string to output the data for the origin address, the destination address, and the cost
        public override string ToString() =>
            $"Origin Address: {Oaddress}\n" +
            $"Destination Address: {Daddress}\n" +
            $"Total cost: {CalcCost():C}\n";
    }
}