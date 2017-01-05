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
            // Anforderung -> Addieren: Benutzer gibt zwei Zahlen ein zum Addieren.

            Console.Write("Bitte gib die erste Zahl ein: "); // gibt Text aus als Anweisung für den Nutzer.
            string ersteZahl = Console.ReadLine();

            Console.Write("Bitte gib die zweite Zahl ein: "); // gibt Text aus als Anweisung für den Nutzer.
            string zweiteZahl = Console.ReadLine();

            // String in Zahl konvertieren
            float zahl1 = Convert.ToSingle(ersteZahl); 
            float zahl2 = float.Parse(zweiteZahl);

            // Berechnung wird ausgeführt
            float ergebnis = Addieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            
            // Ausgabe
            Console.WriteLine("Das Ergebnis ist {0}", ergebnis);
            WarteAufBenutzerEingabe();
        }

        /// <summary>
        /// Addiert zweit Werte zusammen.
        /// </summary>
        /// <param name="wert1"></param>
        /// <param name="wert2"></param>
        /// <returns></returns>
        static float Addieren(float wert1, float wert2)
        {
            // Addiert wert1 mit wert2
            float summe = wert1 + wert2;
            // Gibt das Ergebnis aus der Methode zurück
            return summe;
        }

        /// <summary>
        /// Hält die Kommandozeile offen und wartet auf eine Tasten eingabe.
        /// </summary>
        static void WarteAufBenutzerEingabe()
        {
            Console.WriteLine("Zum beenden einfach die EINGABETASTE Drücken!");
            Console.ReadLine();
        }      
    }
}
