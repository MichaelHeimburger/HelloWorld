using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello World");
            // Part One greetings statement
            string messageOne = "Hellow World!";
            string messageTwo = "I am Spartacus";

            // Part two set initial spartacus atributes
            int ageOne = 35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.5;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            //// Part three display variable values
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);

            //// Part Four mathmatical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);

            //// part five variable resassignment
            //ageTwo = 70;
            //heightTwo = 35.12345;
            //weightTwo = -429.1234573f;

            ////part six mathmatical operator examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////part seven increment and decrament operator examples
            //ageTwo = ageTwo + 1;
            //Console.WriteLine(ageTwo);
            //ageTwo ++;
            ////Console.WriteLine(ageTwo);
            ////ageTwo--;
            ////Console.WriteLine(ageTwo);

            ////part eight concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am" + " " + ageOne + " " + "years old," + " " + "and it is" + " " + isGodLikeOne+ " " + "that I am godlike.");
            //Console.WriteLine("I weigh around" + " " +weightOne + "  "+ "pounds, and I am around"+ " " + heightTwo + " " + "inches tall.");
            //Console.WriteLine("My father is {0} years old,and it is {1} that he is a god", ageThree, isGodLikeOne);
            //Console.WriteLine("I am {0} years old and it is {1} that I am a god.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightTwo);

            ////part nine string equality samples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //    //Part ten string length examples
            //    int messOneLength = messageOne.Length;
            //    int messTwoLength = messageTwo.Length;

            //    Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //    Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //    Console.WriteLine("The length of messageOne is " + messOneLength);
            //    Console.WriteLine("The length of messageTwo is " + messTwoLength);

            ////Part 11: Condition examples
            //string cityOne = "Vesuvius";
            //string cityTwo = "Nola";
            //string cityThree = "Nuceria";
            //int cityOneDistance, cityTwoDistance, cityThreeDistance;

            ////Solicit user input
            //Console.WriteLine("What is the distance to {0}?", cityOne);
            //cityOneDistance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + cityTwo + "?");
            //cityTwoDistance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //cityThreeDistance = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier?");
            //string job = Console.ReadLine();

            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job == "cook") || (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are staying home.");
            //}

            //switch (job)
            //{
            //    case "infantry":
            //        Console.WriteLine("You will carry a sword.");
            //        break;

            //    case "archer":
            //        Console.WriteLine("You will carry a bow and arrow.");
            //        break;

            //    case "supply":
            //        Console.WriteLine("You will carry pots and pans.");
            //        break;

            //    case "specialist":
            //        Console.WriteLine("You will operate the catapult.");
            //        break;

            //    default:
            //        Console.WriteLine("You will ride horseback.");
            //        break;
            //}
            // part tweleve array examples
            string[] foodList = new string[5];
            foodList[0] = "Milk";
            foodList[1] = "Fruit";
            foodList[2] = "Meat";
            foodList[3] = "Wine";
            foodList[4] = "Bread";

            //        Console.WriteLine("{3}, {1}, {2}, {0}, {4}", foodList[0], foodList[1],
            // foodList[2], foodList[3], foodList[4]);

            int[] foodAmount = new int[] { 1000, 1000, 2000, 10000, 1500 };
            Console.WriteLine(foodAmount[0] + ", " + foodAmount[1] + ", " +
    foodAmount[2] + ", " + foodAmount[3] + ", " + foodAmount[4]);
            Console.WriteLine(foodAmount.Length);

            //string[] elements = messageTwo.Split(' '); //is splitting the string based on spaces via (' ')
            //Console.WriteLine(elements[0]);  //prints I
            //Console.WriteLine(elements[1]);  //prints am
            //Console.WriteLine(elements[2]);  // prints spartacus

            //List<string> foodList = new List<string>();
            //foodList.Add("Milk");
            //foodList.Add("Fruit");
            //foodList.Add("Meat");
            //foodList.Add("Wine");
            //foodList.Add("Bread");

            //foodList.Add("Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);
            //foodList.Remove("Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);
            //foodList.Insert(1, "Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);
            //foodList.RemoveAt(1);
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            // Part thirteen while loop example
            //string action = " ";
            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            // }

            //string action = " ";
            //    do
            //    {
            //        Console.WriteLine("What is your rank soldier?");
            //        string rank = Console.ReadLine();

            //        Console.WriteLine("What is your age soldier?");
            //        int age = int.Parse(Console.ReadLine());
            //        Console.WriteLine("What is your job soldier?");
            //        string job = Console.ReadLine();

            //        if ((rank == "officer") || (age <= 26))
            //        {
            //            Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //        }
            //        else if ((job == "cook") || (age >= 26))
            //        {
            //            Console.WriteLine("My army has to eat. Pack your pots and pans");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry you are staying home.");
            //        }
            //        Console.WriteLine("Add another? Type exit to quit");
            //        action = Console.ReadLine();
            //    } while (action != "exit");

            //Part fourteen for-loop examples
            //for (int i = 0; i < foodAmount.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}


            for (int i = 0; i < foodAmount.Length; i++)
            {
                Console.WriteLine("Enter a value for " + foodList[i]);
            foodAmount[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}