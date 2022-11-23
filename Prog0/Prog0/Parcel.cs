//E4182
// Program #: 0
// Due Date: 9/7/2020
// Section 76
/* Description of class Parcel: Class Parcel is the base class. All parcles will be derived from it. It stores the origin address,
 * The destination address, calculaes the cost and displays the final result on the console */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog0
{
    abstract class Parcel
    {
        private Address originAddress; // The origin address class is stored as an Address object which is a "Has-a" relationship.
        private Address destAddress; // The destination address class is stroed as an Address object which is a "Has-a" relationship.

        // Precondition: Both of the origin and destination addresses have been validiated
        // Postcondition: The address objects are set to the values of the paramaters
        public Parcel(Address OriginAddress, Address DestAddress)
        {
            // Passing the parameters through the properties
            Oaddress = OriginAddress;
            Daddress = DestAddress;
        }

        public Address Oaddress
        {
            // Precondition: None
            // Postcondition: origin address has been returned
            get
            {
                return originAddress;
            }

            // Precondition: Origin address is not null or whitespace
            // Postcondition: The origin address has been set or an error message has been shown
            private set
            {
                if (value is null)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), originAddress, $"Invalid Address");
                }
                else
                {
                    originAddress = value;
                }
            }
        }

        public Address Daddress
        {

            // Precondition: None.
            // Postcondition: The destination address has been returned
            get
            {
                return destAddress;
            }


            // Precondition: Destination address is not null or whitespace
            // Postcondition: The value for destination address has been set or an error message has been shown.
            private set
            {
                if (value is null)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), destAddress, $"Invalid Address");
                }
                else
                {
                    destAddress = value;
                }
            }
        }
        
        // This abstract method calculates the cost. The reason it is abstract is we do not know how to calculate that number yet 
        public abstract decimal CalcCost();

        // This method returns the origin and destination addresses as well as the cost as a string.
        public override string ToString() =>
            $"Origin Address: {Oaddress}\n" +
            $"Destination Address: {Daddress}\n" +
            $"Total cost: {CalcCost():C}\n";
    }


}