using System;

namespace number_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int easy_num = random.Next(1, 10);
            int medium_num = random.Next(1, 20);
            int hard_num = random.Next(1, 50);
            int chances_used = 1;
            string level = "";
            int guess = 0;

            Console.Write("There are three levels, Easy, Medium and Hard. Pick one: ");
            level = Console.ReadLine();
            level = level.ToLower();

            while (level == "easy")
            {
                Console.Write("Guess a number within 1-10: ");
                guess = int.Parse(Console.ReadLine());
                if (guess == easy_num)
                {
                    Console.WriteLine("Congratulations!, You won!");
                    break;

                }
                else if(chances_used < 6)
                {
                    Console.WriteLine("Try again, kindly note that you have used" + " " + chances_used +  " " + "out of 6");
                }
                else
                {
                    Console.WriteLine("Game Over!");
                    break;
                } 
                chances_used ++;
            }

            while (level == "medium")
            {
                Console.Write("Guess a number within 1-20: ");
                guess = int.Parse(Console.ReadLine());
                if (guess == medium_num)
                {
                    Console.WriteLine("Congratulations!, You won!");
                    break;

                }
                else if(chances_used < 4)
                {
                    Console.WriteLine("Try again, kindly note that you have used" + " " + chances_used +  " " + "out of 4");
                }
                else
                {
                    Console.WriteLine("Game Over!");
                    break;
                } 
                chances_used ++;


        }

        while (level == "hard")
            {
                Console.Write("Guess a number within 1-50: ");
                guess = int.Parse(Console.ReadLine());
                if (guess == hard_num)
                {
                    Console.WriteLine("Congratulations!, You won!");
                    break;

                }
                else if(chances_used < 3)
                {
                    Console.WriteLine("Try again, kindly note that you have used" + " " + chances_used +  " " + "out of 3");
                }
                else
                {
                    Console.WriteLine("Game Over!");
                    break;
                } 
                chances_used ++;

    }
}
}}
