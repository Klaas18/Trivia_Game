using System;

namespace Trivia_Game
{
    class Program 
    {
        static void Main(string[] args)
        {
           
           
            QuestionsClass questionsClass = new QuestionsClass();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("||TRIVIA GAME||");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Do You Want To Start (y) (n)");
           
            char start = char.Parse(Console.ReadLine().ToLower());
            Console.Clear();
            
            if (start == 'y')
            {
                for (int i = 0; i <= 100; i++)
                {
                    
                    questionsClass.Vragen();
                    Console.Clear();
                    
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine(questionsClass.playerName+ " Got " +questionsClass.playerScore + "/" + questionsClass.questionAmmount + "Right");
                   // Console.WriteLine(questionsClass.playerName +" Score = "+ questionsClass.playerScore);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Do you want To Restart (y) (n)");
                    Console.ResetColor();
 
                    char restart = char.Parse(Console.ReadLine().ToLower()); // ask if player want to restart the game
                    Console.Clear();
                    if (restart == 'n')
                    {
                        break;
                    }
                }
            }

                        
        }
           
       

    }
}
