// 5272456
// prog 5 ec
// 12/9/21
//cis 200-50
// this class contains test data for program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5_EC
{
    class Program
    {
        static void Main(string[] args)
        {
            // first test data
            int[] array = { 9, 3, 5, 2, 1, 0, 4, 6, 7, 8 };
            //second test data
            double[] array2 = { 8.8, 7.7, 6.6, 4.4, 1.1, 2.2, 5.5, 3.3, 9.9, 1.1 };
            // third test data
            string[] array3 = { "five", "three", "four", "seven", "nine", "ten", "two", "six", "eight" };




            // new integer tree
            Tree<int> tree = new Tree<int>();
            Console.WriteLine($"insert into {nameof(tree)}:");

            foreach (IComparable data in array)
            {
                Console.Write($"{data} ");
                tree.NewNode(data);
            }



            // performs inorder transversal
            Console.WriteLine($"\ninorder transversal of {nameof(tree)}");
            tree.inordertransversal();
            Pause();




            // makes tree double
            Tree<double> tree2 = new Tree<double>();
            Console.WriteLine($"inserting into {nameof(tree2)}:");

            foreach (IComparable data in array2)
            {
                Console.Write($"{data} ");
                tree2.NewNode(data);
            }




            // this performs the inorder transversal
            Console.WriteLine($"\ninorder traversal of {nameof(tree2)}");
            tree2.inordertransversal();
            Pause();




            // makes tree string
            Tree<string> tree3 = new Tree<string>();
            Console.WriteLine($"inserting into {nameof(tree3)}:");

            foreach (IComparable data in array3)
            {
                Console.Write($"{data} ");
                tree3.NewNode(data);
            }




            // this performs the inorder transversal
            Console.WriteLine($"\ninorder traversal of {nameof(tree3)}");
            tree3.inordertransversal();
            Pause();


        }
        // there is no pre condition
        // Postcondition: method that pauses the program for user to read, program will continue once user presses enter
        public static void Pause()
        {
            Console.WriteLine("\nPlease press enter to continue");
            Console.ReadLine();
            Console.Clear();  
        }
    }

}
