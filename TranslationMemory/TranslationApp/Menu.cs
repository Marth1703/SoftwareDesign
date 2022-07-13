using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationApp
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            var application = Application.GetInstance();
            application.SetUpApplication();


            //string json = JsonConvert.SerializeObject(loginData, Formatting.Indented);
            //File.WriteAllText(@"..\..\Data\loginData.json", json);
            //Console.WriteLine(Environment.CurrentDirectory);
            //Console.WriteLine(File.ReadAllText(@"..\..\Data\loginData.json"));

            Console.ReadLine();
        }
    }
}
