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
            float zahl1 = EingabeWert("Gib die erste Zahl ein: ");
            float zahl2 = EingabeWert("Gib die zweite Zahl ein: ");

            // Berechnung wird ausgeführt
            float ergebnis = Addieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            
            // Ausgabe
            Console.WriteLine("Das Ergebnis ist {0}", ergebnis);

            // Kommandozeile wartet auf eine Benutzereingabe
            WarteAufBenutzerEingabe();
        }

        /// <summary>
        /// Gibt einen Anweisungstext für den Benutzer in der Konsole aus und wandelt die Benutzereingabe vom Typ string in einen float um.
        /// </summary>
        /// <param name="ausgabeText"></param>
        /// <returns></returns>
        static float EingabeWert(string ausgabeText)
        {
            Console.Write(ausgabeText); // gibt Text aus als Anweisung für den Nutzer.
            string wert = Console.ReadLine(); // Die Konsoleneingabe wirt in die Variable wert gespeichert.
            float wertZuZahl = float.Parse(wert); // Der eingegeben Wert string wird in einen float gewandelt.

            return wertZuZahl; //Ausgabe des eingegbenen Wertes.
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
