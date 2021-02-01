using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            int incorrectUser = 0;
            int incorrectPass = 0;

            while (incorrectUser < 3)
            {
                string userName = "admin";
                string password = "1234";

                Console.Write("Enter your username: ");
                string enteredUserName = Console.ReadLine().ToLower().Trim();

                if (enteredUserName == userName)
                {
                    while (incorrectPass < 3)
                    {
                        Console.Write("\nEnter your password: ");
                        string enteredPassword = Console.ReadLine().ToLower().Trim();

                        if (enteredPassword == password)
                        {
                            Console.WriteLine("You have been granted access");
                        }//end password if
                        else
                        {
                            Console.WriteLine("You have entered the incorrect password");
                            incorrectPass++;
                            if (incorrectPass == 3)
                            {
                                incorrectUser = 3;
                            }
                        }//end password else
                    
                    }//end incorrectPass while
                }//end userName if
                else
                {
                    Console.WriteLine("The username you entered is incorrect.");
                    incorrectUser++;
                }//end userName else

            }//end incorrectUser while
            Console.WriteLine("You have been locked out for entering the incorrect credentials too many times.");

        }//end main()
    }//end class
}//end namespace
