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
            SoundPlayer player = new SoundPlayer(@"C:\Users\lab_services_student\Desktop\PROG6221_Part1_ST10451904\Chatbot\08pgn-1x0pn.wav");
            player.PlaySync(); // or .Play() for async

            // Proceed with chatbot logic
            TypeEffect("Starting Cybersecurity Awareness Bot...");
            // Continue chatbot logic here
            DisplayAsciiArt();
            TextGreeting();
            ResponseSystem();

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
        static void ResponseSystem()
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
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                TypeEffect("\nAsk me a question: ");
                string input = Console.ReadLine()?.ToLower();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypeEffect("I didn't quite understand that. Could you rephrase?");
                    Console.ResetColor();
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (input.Contains("how are you"))
                    TypeEffect("I'm just a bunch of code, but I'm running smoothly!");
                else if (input.Contains("purpose"))
                    TypeEffect("I'm here to help you learn about cybersecurity and stay safe online.");
                else if (input.Contains("password"))
                    TypeEffect("Use strong, unique passwords and enable two-factor authentication.");
                else if (input.Contains("phishing"))
                    TypeEffect("Be cautious with emails asking for personal info—verify before clicking links.");
                else if (input.Contains("safe browsing"))
                    TypeEffect("Stick to secure sites (https://), use antivirus software, and avoid suspicious downloads.");
                else if (input.Contains("exit") || input.Contains("quit") || input.Contains("bye"))
                {
                    TypeEffect("Thank you for chatting! Stay safe online. ");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypeEffect("I didn't quite understand that. Could you rephrase?");
                }
               
            }
            Console.ResetColor();
        }



    }
}

