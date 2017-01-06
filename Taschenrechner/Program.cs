using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {

        static void Main(string[] args)
        {
            // Konsolen Typo
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorSize = 100;
            Console.Title = "Rechner";

            // Benutzereingaben werden abgefragt.
            float zahl1 = HoleBenutzerdaten("Gib die erste Zahl ein: ");
            float zahl2 = HoleBenutzerdaten("Gib die zweite Zahl ein: ");
            string operation = HoleOperator("gib die auszuführende Operation ein (+ - / *): ");

            // Berrechnung wird ausgeführt und Ausgegeben. Gelöst mit Switch
            RechnerModel model = new RechnerModel();
            float ausgabeErgebnis = model.BerrechneMitSwitchCase(operation, zahl1, zahl2);
            Console.WriteLine("Das Ergebnis {1} {0} {2} = {3}",operation ,zahl1, zahl2, ausgabeErgebnis);

            // Kommandozeile wartet auf eine Benutzereingabe
            WarteAufBenutzerEingabe("Zum beenden einfach die EINGABETASTE Drücken!");

        }

        /// <summary>
        /// Gibt einen Anweisungstext für den Benutzer in der Konsole aus und wandelt die Benutzereingabe vom Typ string in einen float um.
        /// </summary>
        /// <param name="ausgabeText"></param>
        /// <returns></returns>
        static float HoleBenutzerdaten(string ausgabeText)
        {
            Console.Write(ausgabeText); // gibt Text aus als Anweisung für den Nutzer.
            string wert = Console.ReadLine(); // Die Konsoleneingabe wirt in die Variable wert gespeichert.
            float wertZuZahl = float.Parse(wert); // Der eingegeben Wert string wird in einen float gewandelt.

            return wertZuZahl; //Ausgabe des eingegbenen Wertes.
        }

        /// <summary>
        /// Operator Benutzereingabe
        /// </summary>
        /// <param name="ausgabeText"></param>
        /// <returns></returns>
        static string HoleOperator(string ausgabeText)
        {
            Console.Write(ausgabeText); // gibt Text aus als Anweisung für den Nutzer.
            string wert = Console.ReadLine(); // Die Konsoleneingabe wirt in die Variable wert gespeichert.

            return wert; //Ausgabe des eingegbenen Wertes.
        }

        /// <summary>
        /// Hält die Kommandozeile offen und wartet auf eine Tasten eingabe.
        /// </summary>
        static void WarteAufBenutzerEingabe(string ausgabeText)
        {
            Console.WriteLine(ausgabeText);
            Console.ReadLine();
        }      
    }
}
