using System;
using System.Media;
namespace Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void TypeEffect(string text, int delay = 30)
            {

                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(delay);
                }
                Console.WriteLine();
            }
            // Play greeting audio
            SoundPlayer player = new SoundPlayer(@"C:\Users\lab_services_student\Desktop\Chatbot\08pgn-1x0pn.wav");
            player.PlaySync(); // or .Play() for async

            // Proceed with chatbot logic
            TypeEffect("Starting Cybersecurity Awareness Bot...");
            // Continue chatbot logic here
            DisplayAsciiArt();
            TextGreeting();

        }
        static void DisplayAsciiArt()
        {
            string asciiArt = @" 
  ____      _                                        _ _            
 / ___|   _| |__   ___ _ __ ___  ___  ___ _   _ _ __(_) |_ _   _    
| |  | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | |   
| |__| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| |   
 \____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, |   
   / \|___/   ____ _ _ __ ___ _ __   ___  ___ ___  | __ )  |___/ |_ 
  / _ \ \ /\ / / _` | '__/ _ \ '_ \ / _ \/ __/ __| |  _ \ / _ \| __|
 / ___ \ V  V / (_| | | |  __/ | | |  __/\__ \__ \ | |_) | (_) | |_ 
/_/   \_\_/\_/ \__,_|_|  \___|_| |_|\___||___/___/ |____/ \___/ \__|
    ";

            Console.WriteLine(asciiArt);
        }

        static void TextGreeting()
        {
            void TypeEffect(string text, int delay = 30)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(delay);
                }
                Console.WriteLine();
            }
            TypeEffect("\nWhat's your name? ");
            string userName = Console.ReadLine();

            TypeEffect($"\nWelcome, {userName}! Let's explore how to stay safe online together.");
        }


    }
}

