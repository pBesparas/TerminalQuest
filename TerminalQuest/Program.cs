using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabeln
            string name = "";
            int leben = 100, maxleben = 100, angriff = 15, level = 1, gold = 0;
            bool checkName = true;

            // Wilkommen, Namens eingaben, Charakterübersicht
            while (checkName)
            {
                Console.Clear();
                Console.WriteLine("\n\t****** Wilkommen bei Terminal Quest ******");
                Console.Write("\n\tWie soll dein Charakter heißen: ");
                name = Console.ReadLine();

                checkName = false;
                if(string.IsNullOrWhiteSpace(name))
                { 
                  Console.WriteLine("\n\tFehler: Gebe einen Namen ein");
                  Console.ReadLine(); 
                  checkName = true; 
                }
                
            }
            // Charakterübersicht
            Console.WriteLine("\n\t****** Charakterübersicht ******");
            Console.WriteLine("\n\tName:     {0}", name);
            Console.WriteLine("\tLeben:    {0}/{1}", leben, maxleben);
            Console.WriteLine("\tAngriff:  {0}", angriff);
            Console.WriteLine("\tLevel:    {0}", level);
            Console.WriteLine("\tGold:     {0}", gold);




        }
    }
}
