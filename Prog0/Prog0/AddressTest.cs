//E4182
// Program #: 0
// Due Date: 9/7/2020
// Section 76
/* This class just tests the code using a few different parcel objects and addresses.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog0
{
    class AddressTest
    {
        // Precondition: None
        // Postconditoin: The code has been tested
        static void Main(string[] args)
        {
            // Addresses used for testing
            Address address1 = new Address("Bob Jones", "1738 Eastern Parkway", "Louisville", "KY", 57890);
            Address address2 = new Address("Laura Barrnett", "386 Elizabeth Avenue", "Hoover", "AL", 35124);
            Address address3 = new Address("Bill Murray", "221 Euclid Street", "Santa Monica", "CA", 90402);
            Address address4 = new Address("Jimmy Hendrix", "1234 Hollywood Boulevard", "Los Angeles", "CA", 90028);

            // Letters used for testing that contain the values for the fixed cost
            Letter letter1 = new Letter(address4, address3, 17);
            Letter letter2 = new Letter(address2, address1, 15);
            Letter letter3 = new Letter(address3, address2, 12);

            // This is the list of parcel objects.
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(letter1);
            parcels.Add(letter2);
            parcels.Add(letter3);


            // loop used to print items
            foreach (Parcel item in parcels)
            {
                WriteLine(item.ToString()); // WriteLine method calls the parcel objects to display the output.
            }
        }
    }
}