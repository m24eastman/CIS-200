// program 4
// cis 200-50
// 11/29/2021
//5272456
// this is a test class to enter parcels so program can make sure it runs properly

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class test
    {
        // there is no pre condition
        // post condition is that parcels are now made and shown

        static void Main(string[] args)
        {
            // test data 
            Address A1 = new Address("John Smith", "123 Any St.", "Apt. 45", "Louisville", "KY", 40202); // first test address
            Address A2 = new Address("Jane Doe", "987 Main St.", "Beverly Hills", "CA", 90210); // second test address
            Address A3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", "El Paso", "TX", 79901); // third test address
            Address A4 = new Address("John Crichton", "678 Pau Place", "Apt. 7", "Portland", "ME", 04101); // fourth test address



            // letter test
            Letter L1 = new Letter(A1, A2, 4.20M);
            Letter L2 = new Letter(A3, A2, 5.45M);
            Letter L3 = new Letter(A4, A1, 2.90M);



            //ground test  
            GroundPackage G1 = new GroundPackage(A3, A4, 14, 10, 5, 12.5);
            GroundPackage G2 = new GroundPackage(A1, A4, 12, 30, 21, 10);
            GroundPackage G3 = new GroundPackage(A2, A1, 60, 40, 17, 83);


            // next day air package test
            NextDayAirPackage N1 = new NextDayAirPackage(A1, A3, 25, 15, 15, 85, 7.50M);
            NextDayAirPackage N2 = new NextDayAirPackage(A4, A1, 31, 15, 20, 52, 10.5M);

            // two day air package test
            TwoDayAirPackage T1 = new TwoDayAirPackage(A4, A1, 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage T2 = new TwoDayAirPackage(A2, A3, 15, 61.5, 53, 23, TwoDayAirPackage.Delivery.Early);

            // list all tests
            List<Parcel> parcel;
            parcel = new List<Parcel>();
            parcel.Add(L1);
            parcel.Add(L2);
            parcel.Add(L3);
            parcel.Add(G1);
            parcel.Add(G2);
            parcel.Add(G3);
            parcel.Add(N1);
            parcel.Add(N2);
            parcel.Add(T1);
            parcel.Add(T2);

            // displays the original parcels before shown in order
            Console.WriteLine("original list"); 
            Console.WriteLine("---------------");
            foreach (Parcel par in parcel)
            {
                Console.WriteLine(par);
                Console.WriteLine("---------------");
            }
            Pause();



            // sorts parcels by using default sort
            parcel.Sort(); 
            Console.WriteLine("list of parcels by default");
            foreach (Parcel par in parcel)
            {
                Console.WriteLine(par);
                Console.WriteLine("---------------");
            }
            Pause();




            // sorts parcels in descending order by destination zip
            parcel.Sort(new descendZip()); 
            Console.WriteLine("list of parcels by destination zipcode (descending)");
            foreach (Parcel par in parcel)
            {
                Console.WriteLine(par);
                Console.WriteLine("---------------");
            }
            Pause();


            // extra credit... sorts parcels by type and cost in descending order
            parcel.Sort(new EC()); 
            Console.WriteLine("parcels sorted by type and cost");
            foreach (Parcel par in parcel)
            {
                Console.WriteLine(par);
                Console.WriteLine("---------------");
            }
            Pause();
        }

        // pre condition is that program is running
        // post condition is that pause method is created
        public static void Pause()
        {
            Console.WriteLine("Press any button to continue");
            Console.ReadLine();
            Console.Clear(); 
        }
    }

}
