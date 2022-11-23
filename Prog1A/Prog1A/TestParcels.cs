// Program 1B
// CIS 200-50
// Due: 10/08/2021
// By: Andrew L. Wright (students use Grading ID)
// 5272456

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Michael Jordan", "2673 Fleming R0ad", "Apt. 2",
                "Lexington", "KY", 32173); // Test address 5
            Address a6 = new Address("Vince Carter", "222 Shady Lane", "Apt. 5",
                "Houston", "TX", 89340); // Test address 6
            Address a7 = new Address("Michael Phelps", "5555 Trevilian Way", "Apt. 12",
                "Baltimore", "MD", 43439); // Test address 7
            Address a8 = new Address("Trae Young", "64 Bardstown Rd", "Apt. 69",
                "Louisville", "KY", 40205); // Test address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a5, a7, 4.20M);                             // Letter test object 2
            Letter letter3 = new Letter(a3, a4, 3.10M);                             // Letter test object 3

            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a4, a1, 10, 11, 4, 6.9);          // Ground test object 2
            GroundPackage gp3 = new GroundPackage(a8, a2, 12, 15, 2, 7.7);          // Ground test object 3

            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a2, a8, 31, 10, 10, 66, 8.30M); // Next day test object 2
            NextDayAirPackage ndap3 = new NextDayAirPackage(a5, a4, 25, 30, 30, 58, 9.0M); // Next day test object 3

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a7, a8, 55.2, 32.1, 27.9, 90.0, TwoDayAirPackage.Delivery.Saver); // Two day test object 2
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a5, a1, 62.2, 30.0, 32.9, 101.2, TwoDayAirPackage.Delivery.Saver);// two day test object 3

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            WriteLine("Original List:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            //filter by destination zip code 
            var destzip = from p in parcels orderby p.DestinationAddress.Zip descending select p;

            WriteLine("Parcels are in order by the destination address ZipCode");

            // there is no pre condition
            // post condition is loop returns parcel filtered by dest address in descending order
            foreach (var p in destzip)
            {
                WriteLine(p); WriteLine("====================");
            }
            ReadLine();

            // filter by cost 
            var cost = from p in parcels orderby p.CalcCost() ascending select p;
            WriteLine("Parcels are in order by cost");
            // no pre condition
            // post condition is loop returns filtered cost in ascending order
            foreach (var p in cost)
            {
                WriteLine(p); WriteLine("====================");
            }
            ReadLine();



            // filter by type
            var type = from p in parcels orderby p.GetType().ToString(), p.CalcCost() descending select p;
            WriteLine("Parcels are in order by type and cost");
            // there is no pre condition
            // post condition is loop returns parcels filtered by cost and type descending
            foreach (var p in type)
            {
                WriteLine($"{p.GetType().ToString()} {p.CalcCost():C}");
                WriteLine("====================");
            }
            ReadLine();



            //filter by weight
            var weight = from p in parcels let air = p as AirPackage where air.IsHeavy() && (air != null) orderby air.Weight descending select air;
            WriteLine("Heavy air packages are in order by weight");
            //there is no pre condition
            //post condition is loop returns heavy packages descending 
            foreach (var air in weight)
            {
                WriteLine(air);
                WriteLine("====================");
            }
            ReadLine();
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}