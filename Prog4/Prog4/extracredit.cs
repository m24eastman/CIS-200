// prog 4
// cis 200-50
// 11/29/2021
//5272456
// this is an extra credit program that sorts parcels by type first, then by cost in descending order

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class extracredit : IComparer<Parcel>
    {
        public int Compare(Parcel X, Parcel Y)
        {
            if (X == null && Y == null) return 0;
            if (X == null) return -1;
            if (Y == null) return 1;

            //returns x and y
            string t1 = X.GetType().Name;
            string t2 = Y.GetType().Name;

            // if variables have same type, default to cost
            if (t1.Equals(t2))
            {
                if (X.CalcCost().Equals(Y.CalcCost())) return 0;
                return -1 * X.CalcCost().CompareTo(Y.CalcCost());
            }
            // sort parcels by type
            return t1.CompareTo(t2); 
        }
    }
}
