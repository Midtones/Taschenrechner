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
            float ausgabeErgebnis = BerrechnungMitSwitchCase(operation, zahl1, zahl2);
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
        /// Berrechnet zwei Zahlen mit ausgewählter operation. Note: Methode mit SwitchCase
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="zahl1"></param>
        /// <param name="zahl2"></param>
        static float BerrechnungMitSwitchCase(string operation, float zahl1, float zahl2)
        {
            float ergebnis = 0F; // Variable muss ausserhalb der switch Anweisung stehen!

            switch (operation)
            {
                case "+":
                    ergebnis = Addieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                case "-":
                    ergebnis = Subtrahieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                case "/":
                    ergebnis = Division(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                case "*":
                    ergebnis = Multiplikation(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                default:
                    Console.WriteLine("Dein Operator war ungültig! Du hast {0} eingegeben damit kann ich nicht rechnen!", operation);
                    break;
            }
            return ergebnis;
        }

        /// <summary>
        /// Berrechnet zwei Zahlen mit ausgewählter operation. Note: Methode mit else if
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="zahl1"></param>
        /// <param name="zahl2"></param>
        /// <returns></returns>
        static float BerrechnungMitIfElse(string operation, float zahl1, float zahl2)
        {
            float ergebnis = 0F;
            // Berechnung wird ausgeführt gelöst mit if und else if
            if (operation == "+")
            {
                ergebnis = Addieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            }
            else if (operation == "-")
            {
                ergebnis = Subtrahieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            }
            else if (operation == "/")
            {
                ergebnis = Division(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            }
            else if (operation == "*")
            {
                ergebnis = Multiplikation(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            }
            else
            {
                Console.WriteLine("Dein Operator war ungültig!");
            }
            return ergebnis;
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
