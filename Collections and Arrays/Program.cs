using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a collection that is a list of strings
            var dogs = new List<string>();

            dogs.Add("Bulldog");
            dogs.Add("Collie");
            dogs.Add("Retriever");

            //foreach to move through the list
            foreach (var dog in dogs)
            {
                //display each dog on a different line in a console window
                Console.WriteLine(dog + " ");
            }

            //create an array of intergers

            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };

            foreach (int i in a1)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
