using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(iterator; condition; increment)
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int count = 50; count <= 100; count++)
            //{
            //    Console.Write(count);
            //}

            //string greeting = "My name is Little Bill.";
            //string[] words = greeting.Split(); // This splits the entire string along the white space between the words.
            ////string[] words = { "M", "y", " ", "n", "a" };

            //// Arrays start at zero, so you start with a zero since it's zero index. When you start counting numbers you start at 1.
            //for (int i = 0; i < words.Length; i++) //You don't need a minus 1 since it's less than.
            //{
            //    Console.WriteLine(words[i]);
            //}

            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //string story = "Once upon a time.";
            //string[] stories = story.Split();
            //Array.Reverse(stories);
            //for (int i = 0; i < stories.Length; i++)
            //{
            //    Console.WriteLine(stories[i]);
            //}

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            ///* foreach(type variable in collection) {}*/
            //foreach (string month in months)//(datatype/nameOfTempVariable/in/nameOfarray)
            //{
            //    Console.WriteLine(month); //We only have to enter our temporary variable in this method.
            //}

            ////For each is good for displaying stored items. 
            //string[] bands = { "Metallica", "Nirvana", "Dubioza Kolektiv", "Offspring", "S.A.R.S." };
            //foreach (string band in bands)
            //{
            //    Console.WriteLine(band);
            //}

            //string[] foods = { "burrito", "pizza", "ice cream", "hamburger" };
            //foreach (string food in foods)
            //{
            //    Console.WriteLine(food);
            //}

            //int[] luckyNumber = { 11, 7, 17, 21, 1 };
            //foreach (int number in luckyNumber)
            //{
            //    Console.WriteLine("Your lucky number is: " + number);
            //}

            //string[] headers = { "Name", "Address", "City" };
            //string[,] data =
            //{
            //    {"Dejan","1550 Royalton Rd", "Broadview Heights"},
            //    {"John","1234 Road Rd","City" }
            //};
            //Console.WriteLine(data[1,2]);

            //Console.WriteLine("Would you like to play again ? Yes/No");
            //string playAgain = Console.ReadLine();
            //while (playAgain.ToLower() == "yes")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Would you like to play again ? Yes/No");
            //    playAgain = Console.ReadLine(); //You need this option so that you can exit out of the loop, if it's not there it will run indefinetly.
            //}

            //int counter = 0;

            //while (counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            string patientName;
            int patientID;
            string appointmentTime;
            Console.WriteLine("Would you like to check in a patient ? Yes/No.");
            string appointment = Console.ReadLine();
            while (appointment.ToLower() == "yes")
            {
                Console.WriteLine("PATIENT CHECK IN SYSTEM");
                Console.WriteLine("Please enter the name of the patient.");
                patientName= Console.ReadLine();
                Console.WriteLine("Please enter the six digit patient ID.");
                patientID = int.Parse(Console.ReadLine());
                Console.WriteLine("Is the patients appointment time after 2:00 pm");
                appointmentTime = Console.ReadLine();
                Console.WriteLine("Would you like to check in a patient ? Yes/No.");
                appointment = Console.ReadLine();
            }

            //Do
            //{
            //}
            //While(condition);
            string playAgain;
            do
            {
                Console.WriteLine("Would you like to play a game ? Yes or No.");
                Console.WriteLine("Great game.");
                Console.WriteLine("Would you like to play a game ?");
                playAgain = Console.ReadLine();

            }
            while (playAgain.ToLower()=="yes");
        }
    }
}
