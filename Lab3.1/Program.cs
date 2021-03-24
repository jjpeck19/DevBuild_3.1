using System;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to lab 3.1");

            //Provide information about students in a class
            //prompt the user to ask about a particular student
            //give proper responses according to user-submitted information
            //ask if user would like to learn about another student

            bool done = false;
            while (!done)
            {

                //create 3 arrays and fill them with student information - one with name, one with favorite food, and with previous title.

                string[] name = { "John", "Marilyn", "Bob" };
                string[] fFood = { "Mexican", "Cuban", "Chinese" };
                string[] title = { "Engineer", "Doctor", "Banker" };

                //ask the user which student they want to know about and take the input/ convert it to an interger

                Console.WriteLine("which student do you want to know about? ");
                string student = Console.ReadLine();
                int num = 0;
                bool worked = Int32.TryParse(student, out num);

                if (worked)
                {
                    Console.WriteLine(name[num]);
                    //Console.WriteLine("would you like favorite food or title?\n1: Favorite food\n2: Previous Title");
                    //string choice = Console.ReadLine();
                    //int numchoice = 0;
                    //bool worked1 = Int32.TryParse(choice, out numchoice);
                    

                    
                        try
                        {
                            Console.WriteLine("which would you like to look at?\n1; favorite food\n2: previous title");
                            int choice = Int32.Parse(Console.ReadLine());
                            switch (choice)
                            {

                                case 1:
                                    Console.WriteLine(fFood[num]);
                                    break;
                                case 2:
                                    Console.WriteLine(title[num]);
                                    break;
                                default:
                                    Console.WriteLine("That was not a valid option");
                                    break;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("invalid selection please try again");
                        return ;    
                            
                        }
                    
                    
                    Console.WriteLine("would you like to learn about another student? y/n? ");
                    string playing = Console.ReadLine();
                    if (playing == "n")
                    {
                        done = true;
                    }

                }
                else
                {
                    //prompt for corrected input if it's not an integer or out of range, and prompt again
                    Console.WriteLine("Sorry that is an invalid response please try again.");

                }



            }



        }
    }
}
