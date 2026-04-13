using System;

namespace CyberSecurityBot
{
    public class ChatBot
    {
        private string? userName;

        public void Start()
        {
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                userName = Console.ReadLine();
            }

            Console.WriteLine($"\nHello, {userName}! Ask me something.\n");

            while (true)
            {
                Console.Write("> ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                input = input.ToLower();

                if (input == "exit")
                    break;

                Respond(input);
            }
        }

        private void Respond(string input)
        {
            switch (input)
            {
                case "how are you?":
                    Console.WriteLine("I'm just code, but I'm running perfectly!");
                    break;

                case "what's your purpose?":
                    Console.WriteLine("I promote cybersecurity awareness and safe online practices.");
                    break;

                case "what can i ask about?":
                    Console.WriteLine("You can ask about passwords, phishing, malware, and online safety.");
                    break;

                default:
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                    break;
            }
        }
    }
}