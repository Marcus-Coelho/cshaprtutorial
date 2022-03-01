//using System;

//public class IntCheck
//{
//    static void Main2(string[] args)
//    {
//        int intUserInput = 0;
//        bool validUserInput = false;

//        while (validUserInput == false)
//        {
//            try
//            {
//                Console.Write("Please enter an integer value greater than or equal to 1: ");
//                intUserInput = int.Parse(Console.ReadLine()); //try to parse the user input to an int variable
//            }
//            catch (Exception e) //catch exception for invalid input, such as a letter
//            {
//                Console.WriteLine(e.Message);
//            }

//            if (intUserInput >= 1) { validUserInput = true; }
//            else { Console.WriteLine(intUserInput + " is not a valid input, please enter an integer greater than 0."); }

//        } //end while

//        Console.WriteLine("You entered " + intUserInput);
//        Console.WriteLine("Press any key to exit ");
//        Console.ReadKey();
//    } //end main
//}
