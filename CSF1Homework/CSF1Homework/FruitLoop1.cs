using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[6];

            fruits[0] = "strawberry";
            fruits[1] = "pear";
            fruits[2] = "grape";
            fruits[3] = "orange";
            fruits[4] = "kiwi";
            fruits[5] = "lemon";

            string totalFruits = "";

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
                totalFruits += " . ";
                Console.WriteLine(totalFruits);
                
            }

        }//end Main()
    }//end class
}//end namespace
