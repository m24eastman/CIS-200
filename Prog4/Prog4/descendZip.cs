// prog 4
// cis 200-50
// 11/29/2021
//5272456
// descending zipcode class which will compare parcels and order them by zipcode

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class descendZip : Comparer<Parcel>
    {
        // pre condition is that there must be two parcels
        // post condition is that the method will sort parcels by zipcode
        public override int Compare(Parcel X, Parcel Y) // compare x and y
        {
            if (X == null && Y == null) return 0;
            if (X == null) return 1;
            if (Y == null) return -1;
            return (-1) * X.DestinationAddress.Zip.CompareTo(Y.DestinationAddress.Zip);
            // compares zipcode and sorts them by multiplying by -1
        }
    }
}
