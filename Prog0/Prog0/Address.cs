//E4182
// Program #: 0
// Due Date: 9/7/2020
// Section 76
// This program validates and strores addresses using a To string method and a "Has-A" relationship between classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog0
{
    class Address
    {
        // Backing Fields
        private string _name; // Name from the address
        private string _address_line1; // Line 1 of the address
        private string _address_line2; // Line 2 of the address
        private string _city; // City of the address
        private string _state; // State of the address
        private int _zip; // Zip code of the address 

        public const int MIN_ZIPCODE = 00000; // Minimum number for the address variables used for validation 
        public const int MAX_ZIPCODE = 99999; // Maximum number for the address variables used for validation

        // Precondition :   Name field is not null or whitespace
        //                  Address line 1 not field is null or whitespace 
        //                  Address line 2 not field is null or whitespace
        //                  City field is not null or whitespace 
        //                  State field is not null or whitespace
        //                  Zip code field is between 00000 and 99999
        // Postcondition : The address has been created and its values have been passed through parameters for validation

        public Address(string name, string addressLine1, string addressLine2, string city, string state, int zip)
        {
            // Properties for validation
            Name = name;
            Address1 = addressLine1;
            Address2 = addressLine2;
            City = city;
            State = state;
            Zip = zip;
        }
        // Precondition :   Name field is not null or whitespace
        //                  Address line 1 field is not null or whitespace 
        //                  Address line 2 field is not null or whitespace
        //                  City field is not null or whitespace 
        //                  State field is not null or whitespace
        //                  Zip code field not is between 00000 and 99999
        // Postcondition :  The Adress class has been overloaded, setting the value for Address2 to 0
        public Address(string name, string addressLine1, string city, string state, int zip)
        {
            // Sends the parameters to the properties for validation
            Name = name;
            Address1 = addressLine1;
            Address2 = string.Empty;
            City = city;
            State = state;
            Zip = zip;
        }
        public string Name
        {
            // Precondition: None 
            // Postcondition: The name value has been returned
            get
            {
                return _name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value.Trim()) == false)

                    _name = value.Trim();
                // Precondition: Name is not null or whitespace 
                // Postcondition: The name has been set or an error message has been shown
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Name), value, $"The name of {nameof(Name)} is not valid. Please enter a valid name");
                }
            }
        }

        public string Address1
        {
            // Precondition: none
            // Postcondition: The address line 1 value has been returned
            get
            {
                return _address_line1;
            }

            // Precondition: Address1 is not null or whitespace.
            // Postcondition: Address1 has been set or error messsage has been shown.
            private set
            {
                if (String.IsNullOrWhiteSpace(value.Trim()) == false)

                    _address_line1 = value.Trim();


                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Address1), value, $"Sorry {nameof(Address1)} is not valid. Please enter a valid address. ");
                }
            }
        }

        public string Address2
        {

            // Precondition: none
            // Postcondition: If there is a value for address line 2 it has been returned.
            get
            {
                return _address_line2;
            }

            // Precondition: The value for address line 2 is either null or whitespace
            // Postconditoin: any value for Address2 has been returned.
            private set
            {
                _address_line2 = value.Trim();
            }
        }
        public string City
        {

            // Precondition: None.
            // Postcondition: The value for City has been returned.
            get
            {
                return _city;
            }

            private set
            {

                // Precondition: City is not null or whitespace.
                // Postcondition: The value for city is set or an error message is shown.
                if (String.IsNullOrWhiteSpace(value.Trim()) == false)
                {
                    _city = value.Trim();
                }

                else
                {
                    throw new ArgumentOutOfRangeException(nameof(City), value, $"Sorry {nameof(City)} is not valid. Please enter a valid city.");
                }

            }
        }
        public string State
        {
            // Precondition: None
            // Postcondition: The state variable has been returned.
            get
            {
                return _state;
            }

            private set
            {

                // Preocondition: State is not null or whitespace
                // Postcondition: The value for state has been set or an error message has been shown.
                if (String.IsNullOrWhiteSpace(value.Trim()) == false)
                {
                    _state = value.Trim();
                }

                else
                {
                    throw new ArgumentOutOfRangeException(nameof(State), value, $"Sorry{nameof(State)} is not valid. Please enter a valid State.");
                }
            }
        }

        public int Zip
        {

            // Precondition: None
            // Postcondition: Zip has been returned
            get
            {
                return _zip;
            }
            private set
            {
                // Precondition: The value for zip is not null or whitespace
                // Postcondition: The value for zip has been set or an error message has been shown
                if (value >= MIN_ZIPCODE && value <= MAX_ZIPCODE)
                {
                    _zip = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Zip), value, $"Sorry, {nameof(Zip)} is invalid. Please enter a valid zip code");
                }
            }

        }

        // Precondition: None
        // Postcondition: The address has been returned in the standard format.
        public override string ToString() =>
            $"{Name}\n {((Address2 == string.Empty) ? $"{Address1}\n" : $"{Address1}\n{Address2} \n")}{City},{State} {Zip:D5}";


    }
}