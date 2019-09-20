using System;

namespace ISM_4300_9_19_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user to enter their name
            Console.Write("Please enter your name: ");


            try
            {
                //Stores the input from teh user
                string usersName = Console.ReadLine();

                //create an instance to include in new method
                display_Name(usersName);
              
            }
            catch
            {
                
                Console.WriteLine("Please correct your error");
            }



        }
        //create new method 
        private void display_Name(string usersName)
        {
            //display the user name from the provided input
            Console.WriteLine("Hello " + usersName);
        }
    }
}
 
