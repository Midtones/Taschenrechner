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
            // Benutzereingaben werden abgefragt.
            float zahl1 = HoleBenutzerdaten("Gib die erste Zahl ein: ");
            float zahl2 = HoleBenutzerdaten("Gib die zweite Zahl ein: ");
            string operation = HoleOperator("gib die auszuführende Operation ein (+ - / *): ");

            // Berrechnung wird ausgeführt und Ausgegeben. Gelöst mit Switch

            float ergebnis; // Variable muss ausserhalb der switch Anweisung stehen!

            switch (operation)
            {
                case "+":
                    ergebnis = Addieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    Console.WriteLine("Das Ergebnis {0} + {1} = {2}", zahl1, zahl2, ergebnis);
                    break;

                case "-":
                    ergebnis = Subtrahieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    Console.WriteLine("Das Ergebnis {0} - {1} = {2}", zahl1, zahl2, ergebnis);
                    break;

                case "/":
                    ergebnis = Division(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    Console.WriteLine("Das Ergebnis {0} / {1} = {2}", zahl1, zahl2, ergebnis);
                    break;

                case "*":
                    ergebnis = Multiplikation(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    Console.WriteLine("Das Ergebnis {0} * {1} = {2}", zahl1, zahl2, ergebnis);
                    break;

                default:
                    Console.WriteLine("Dein Operator war ungültig!");
                    break;
            }

            //// Berechnung wird ausgeführt und Ausgegeben. Gelöst mit if und else if
            //if (operation == "+")
            //{
            //    float ergebnis = Addieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            //    Console.WriteLine("Das Ergebnis {0} + {1} = {2}", zahl1, zahl2, ergebnis);
            //}
            //else if (operation == "-")
            //{
            //    float ergebnis = Subtrahieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            //    Console.WriteLine("Das Ergebnis {0} - {1} = {2}", zahl1, zahl2, ergebnis);
            //}
            //else if (operation == "/")
            //{
            //    float ergebnis = Division(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            //    Console.WriteLine("Das Ergebnis {0} / {1} = {2}", zahl1, zahl2, ergebnis);
            //}
            //else if (operation == "*")
            //{
            //    float ergebnis = Multiplikation(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            //    Console.WriteLine("Das Ergebnis {0} * {1} = {2}", zahl1, zahl2, ergebnis);
            //}
            //else
            //{
            //    Console.WriteLine("Dein Operator war ungültig!");
            //}

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
        /// Subtrahiert zweit Wert von einander.
        /// </summary>
        /// <param name="wert1"></param>
        /// <param name="wert2"></param>
        /// <returns></returns>
        static float Subtrahieren(float wert1, float wert2)
        {
            // Subtrahiere wert1 mit wert2
            float differenz = wert1 - wert2;

            // Gibt das Ergebnis der Subtraktion zurück
            return differenz;
        }

        /// <summary>
        /// Dividiert zweit Wert.
        /// </summary>
        /// <param name="wert1"></param>
        /// <param name="wert2"></param>
        /// <returns></returns>
        static float Division(float wert1, float wert2)
        {
            // Subtrahiere wert1 mit wert2
            float differenz = wert1 / wert2;

            // Gibt das Ergebnis der Subtraktion zurück
            return differenz;
        }

        /// <summary>
        /// Multipliziert zweit Wert.
        /// </summary>
        /// <param name="wert1"></param>
        /// <param name="wert2"></param>
        /// <returns></returns>
        static float Multiplikation(float wert1, float wert2)
        {
            // Subtrahiere wert1 mit wert2
            float produkt = wert1 * wert2;

            // Gibt das Ergebnis der Subtraktion zurück
            return produkt;
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
