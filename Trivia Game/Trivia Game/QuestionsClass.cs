using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_Game
{
    public class QuestionsClass
    {
        public int questionAmmount = 15;
        public int playerScore = 0;
        public string playerName;


        public string Questions { get; set; }
        public string Answers { get; set; }

        public bool IsCorrect(string answers) // Vergelijkt Speler zijn antwoord met het correcte Antwoord
        {
            return String.Compare(answers, Answers, true) == 0;
        }
        public void Vragen()
        {
            

            var questions = new List<QuestionsClass>() 
            {
                new QuestionsClass { Questions = "On Which Engine Was Duke Nukem 3D Made?", Answers = "Build Engine" },
                new QuestionsClass { Questions = "What Year Was Duke Nukem 3D Released?", Answers = "1996" },
                new QuestionsClass { Questions = "On Which Engine Was The Original Doom Made?", Answers = "Doom Engine" },
                new QuestionsClass { Questions = "What Year Was The Original Doom Released?", Answers = "1993"},
                new QuestionsClass { Questions = "What Year Was Quake Released?", Answers = "1996"}, // Vraag 5
                new QuestionsClass { Questions = "On Which Engine Was Quake Made?", Answers = "Quake Engine"},
                new QuestionsClass { Questions = "Was Duke Nukem Forever A Good Game? (Yes Or No)", Answers = "No"},
                new QuestionsClass { Questions = "What Year Was Redneck Rampage Released?", Answers = "1997"},
                new QuestionsClass { Questions = "What Year Was Blood Released?", Answers = "1997"},
                new QuestionsClass { Questions = "What Year Was Shadow Warrior Released?", Answers = "1997"}, // Vraag 10
                new QuestionsClass { Questions = "What's The Name Of The Main Character In Blood?", Answers = "Caleb"},
                new QuestionsClass { Questions = "What Year Was Duke Nukem 1 Released?", Answers = "1991"},
                new QuestionsClass { Questions = "What Year Was Duke Nukem 2 Released?", Answers = "1993"},
                new QuestionsClass { Questions = "What Sum 41 Album Came Out In 2004?", Answers = "Chuck"},
                new QuestionsClass { Questions = "What Silverstein Album Came Out In 2005?", Answers = "Discovering The Waterfront"},// Vraag 15
                new QuestionsClass { Questions = "What's The Name Of If I Die First There First EP?", Answers = "My Poison Arm"},
                new QuestionsClass { Questions = "What's Sum 41 There Most Famous Song?", Answers ="In Too Deep"},
                new QuestionsClass { Questions = "What Year Was Wolfenstein 3D Released?", Answers = "1992"},
                new QuestionsClass { Questions = "Which Band Did Lemmy Kilmister Play In?", Answers = "Motorhead"},
                new QuestionsClass { Questions = "How Many Albums Do Sum 41 Have?", Answers = "7"}, // 20 Vragen
                new QuestionsClass { Questions = "Who's The Drummer From Blink 182?", Answers = "Travis Barker"},
                new QuestionsClass { Questions = "What's Marlin Mansons Most Famous (Non Cover) Song?", Answers = "The Beautiful People"},
                new QuestionsClass { Questions = "What's Marlin Mansons Most Famous Cover Song?", Answers = "Sweet Dreams (Are Made Of This)"},
                new QuestionsClass { Questions = "egg?", Answers = "egg"},
                new QuestionsClass { Questions = "On Which Engine Was Blood Made?", Answers = "Build Engine"}, // 25 Vragen
                new QuestionsClass { Questions = "On Which Engine Was Redneck Rampage Made?", Answers = "Build Engine"},
                new QuestionsClass { Questions = "When Was Antichrist Superstar Released?", Answers = "1996"},
                new QuestionsClass { Questions = "What's God His Name?", Answers = "Geoffrey"},
                new QuestionsClass { Questions = "Never?", Answers = "Gonna Give You Up"},
                new QuestionsClass { Questions = "What Year Was Duke Nukem Forever Released?", Answers = "2011"}, // 30 Vragen
            };

            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please Enter A Name"); // Ask For The Players Name And saves it
                                                      
            playerName = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Do You Want To Change How Many Question You Get (y) (n)"); // Ask if the player wants to change question amount
            Console.WriteLine("Standard Is 15 Questions");

              
            char changeQ = char.Parse(Console.ReadLine().ToLower());
            Console.Clear();

            if (changeQ == 'y')
            {
                Console.WriteLine("How Many Questions?");
                questionAmmount = Convert.ToInt32(Console.ReadLine()); // Set The Question Ammount (Als Het getaal te hoog is Terug naar standard 15 toe)
            }
            else
            {

                Console.WriteLine("Standard Is Now 15");
               
            }
            if (questionAmmount >= 31 || questionAmmount <= 14) // if player inputs a number bellow 15 or above 30 questionAmount becomes 15
            {
                questionAmmount = 15;
            }

            Console.Clear();
          
           
            foreach (var a in questions.OrderBy(q => random.Next()).Take(questionAmmount)) // Zet De vragen op een Random volgorde neer     
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("::::" + playerName + "::::");
                Console.WriteLine("::::" + "Score = " + playerScore + "::::");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(a.Questions); // should be (a.Questions)

                  var answers = Console.ReadLine().ToLower();
               if (a.IsCorrect(answers)) // should be (a.IsCorrect(answers)
               {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Good");
                    Console.ResetColor();
                  playerScore += 1;
                  
               }
               else
               {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("False");
                    Console.ResetColor();
                
               }                                
            }                      
        }
    }
}
