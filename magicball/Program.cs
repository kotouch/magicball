using System;

namespace magicball
{
    class Program
    {
        static Random randomObject = new Random();


        static void Main(string[] args)



        {
            QuestionLoop();
        }
        static string GetQuestionFromUser()
        {
            Console.Write("What question do you have?");
            string questionString = Console.ReadLine();
            return questionString;

        }
        static void QuestionLoop()
        {
            while (true)
            {
                string questionString = GetQuestionFromUser();
                int randomNumber = randomObject.Next(4);
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("no");
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("yes");
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine(" dont know why you asking me?");
                            break;

                        }
                }

            }

        }
    }
}

