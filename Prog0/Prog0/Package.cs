//5272456
// cis 200-50
// prog 1a
// 09/27/2021
// derives from parcel class, using the information to create package

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    //inheriting from parcel class
    //there is no pre condition
    // post conditin is that new, derived, package class is created, allowing more information to be inputted
    abstract class Package : Parcel
    {
        // backing fields.
        private double height; // variable for height
        private double width; // variable for width
        private double length; // variable for length
        private double weight; // variable for weight

        // there is no pre condition
        // post condition is package obj being created
        public Package(Address originAddress, Address destinationAddress, double length, double width, double height, double weight) : base(originAddress, destinationAddress)
        {
            Height = height;
            Width = width;
            Length = length;
            Weight = weight;
        }
        // there is no pre condition
        // post condition is weight value will be returned.
        public double Weight
        {
            get
            {
                return weight;
            }
            // pre condition is that value is not 0
            // post condition is that weight is set.
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"Weight, {nameof(value)}, is invalid. Enter a valid weight");
                }
            }
        }
        //there is no pre condition
        // post condiiton is height value will be returned.
        public double Height
        {
            get
            {return height;}
            // pre condition is that value cannot be 0
            // post condition is that height is set
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException($"Height, {nameof(value)}, is invalid. Enter a new height.");
                }
            }
        }
        // there is no pre condition
        // post condition is that the length value is returned
        public double Length
        {
            get
            {
                return length;
            }
            // pre condition is that value cannot be 0
            // post condition is that length is set.
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"Length, {nameof(value)}, is invalid. Enter a valid length.");
                }
            }
        }
        // there is no pre condition
        // posst condition is width value will be returned.
        public double Width
        {
            get
            { return width; }
            // pre condition is that value cannot be 0
            // post condition is that width is set.
            set
            {
                if (value< 0)
                {
                    throw new ArgumentOutOfRangeException($"Width, {nameof(value)}, is invalid. Enter a new width.");
                }
            }
        }
        // there is no pre condition
        // post condition is string being returned and on different lines
        public override string ToString()
        {
            return $"Length:{Length}" +
                $"Width:{Width}" +
                $"Height:{Height}" +
                $"Weight:{Weight}";
        }
    }
}
