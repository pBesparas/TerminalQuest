using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TerminalQuest
{
    internal class Program
    {

        static void CharakterAnzeigen (string name, int leben, int maxLeben, int angriff, int level, int gold) // Charakterübersicht
        {
            Console.Clear();
            Console.WriteLine("\n\t****** Charakterübersicht ******");
            Console.WriteLine("\n\tName:     {0}", name);
            Console.WriteLine("\tLeben:    {0}/{1}", leben, maxLeben);
            Console.WriteLine("\tAngriff:  {0}", angriff);
            Console.WriteLine("\tLevel:    {0}", level);
            Console.WriteLine("\tGold:     {0}", gold);
            Console.Write("\n\tDrücke Enter um weiterzukommen ");
            Console.ReadLine();
        }

        static int BerechneHeilung (int leben,int maxLeben, int heilung)
        {
            int endLeben, rechnung;
            endLeben = leben + heilung;
            if (endLeben > maxLeben)
            {
                rechnung = endLeben - 100;
                endLeben -= rechnung;
            }

            return endLeben;
        }

        static void Main(string[] args)
        {

            // Variabeln
            string name = "";
            int leben = 100, maxLeben = 100, angriff = 15, level = 1, gold = 0;
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
                  Console.Clear();
                  Console.WriteLine("\n\tFehler: Es wurde kein Name eingegeben");
                  Console.Write("\n\tDrücke Enter um wieder zurück zu kommen ");
                  Console.ReadLine(); 
                  checkName = true; 
                }
                
            }

            CharakterAnzeigen(name, leben, maxLeben, angriff, level, gold);

            // Menu
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\t****** Hauptmenü ******");
                Console.WriteLine("\n\t[1] Charakter anzeigen");
                Console.WriteLine("\t[2] Abenteuer");
                Console.WriteLine("\t[3] Inventar");
                Console.WriteLine("\t[0] Spiel beenden");
                Console.Write("\n\tGebe eine Zahl ein: ");
                bool erfolgreich = int.TryParse(Console.ReadLine(), out int eingabe);
                if (!erfolgreich) 
                {
                    Console.Clear();
                    Console.WriteLine("\n\tFehler: Es wurde keine Zahl eingegeben ");
                    Console.Write("\n\tDrücke Enter um wieder zurückzukommen ");
                    Console.ReadLine();
                    continue; 
                }

                switch (eingabe) 
                {
                    case 1: // Charakter anzeigen
                        CharakterAnzeigen(name, leben, maxLeben, angriff, level, gold);
                        break;
                    case 2: //Abenteuer
                        Console.Clear();
                        Console.WriteLine("\n\tNoch nicht Fertig");
                        Console.Write("\n\tDrücke Enter um wieder zurückzukommen ");
                        Console.ReadLine();
                        break;
                    case 3: //Inventar
                        Console.Clear();
                        Console.WriteLine("\n\tNoch nicht Fertig");
                        Console.Write("\n\tDrücke Enter um wieder zurückzukommen ");
                        Console.ReadLine();
                        break;
                    case 0: //Spiel beenden
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tFehler: Ungültige Menüoption");
                        Console.Write("\n\tDrücke Enter um wieder zurückzukommen ");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
