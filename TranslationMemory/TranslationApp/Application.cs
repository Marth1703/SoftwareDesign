using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationApp
{
    public sealed class Application
    {

        private static Application _instance;

        public Dictionary<string, string> LoginData { get; }
        private Application()
        {
            LoginData = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(@"..\..\Data\loginData.json"));
        }
        public static Application GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Application();
            }
            return _instance;
        }

        private void SetConsoleTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TranslationApp\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void SetUpApplication()
        {
            SetConsoleTitle();
            Console.WriteLine("Select starting option:\n");
            Console.WriteLine("\t{0, -20} {1, 5}", "Login","[a]");
            Console.WriteLine("\tContinue without login [w]");
            Console.WriteLine("\t{0, -20} {1, 5}","Close application", "[q]");

            switch (Console.ReadKey().KeyChar)
            {
                case 'a':
                    LoginProcess();
                    break;
                case 'w':
                    Console.WriteLine("work");
                    break;
                case 'q':
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
        private void LoginProcess()
        {
            //var jsonLoginData = File.ReadAllText(@"..\..\Data\loginData.json");
            //var availableLoginData = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonLoginData);
            SetConsoleTitle();
            Console.WriteLine("Type in username:\n");
            var userEntry = Console.ReadLine();
            foreach(var username in LoginData.Keys)
            {
                if(userEntry == username)
                {
                    OnCorrectUsername(username);
                }
            }
            OnWrongUsername();
        }

        private void OnWrongUsername()
        {

        }

        private void OnCorrectUsername(string username)
        {
            Console.WriteLine("hooray");
        }

    }
}
