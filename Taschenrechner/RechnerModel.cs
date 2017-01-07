using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        // Property / Eigenschaft
        public float Ergebnis { get; private set; }

        public RechnerModel()
        {
            Ergebnis = 0F;
        }
        

        /// <summary>
        /// Berrechnet zwei Zahlen mit ausgewählter operation. Note: Methode mit SwitchCase
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="zahl1"></param>
        /// <param name="zahl2"></param>
        public void BerrechneMitSwitchCase(string operation, float zahl1, float zahl2)
        {
               switch (operation)
            {
                case "+":
                    Ergebnis = Addieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                case "-":
                    Ergebnis = Subtrahieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                case "/":
                    Ergebnis = Division(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                case "*":
                    Ergebnis = Multiplikation(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                default:
                    Console.WriteLine("Dein Operator war ungültig! Du hast {0} eingegeben damit kann ich nicht rechnen!", operation);
                    break;
            }
        }

        /// <summary>
        /// Addiert zweit Werte zusammen.
        /// </summary>
        /// <param name="wert1"></param>
        /// <param name="wert2"></param>
        /// <returns></returns>
        private float Addieren(float wert1, float wert2)
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
        private float Subtrahieren(float wert1, float wert2)
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
        private float Division(float wert1, float wert2)
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
        private float Multiplikation(float wert1, float wert2)
        {
            // Subtrahiere wert1 mit wert2
            float produkt = wert1 * wert2;

            // Gibt das Ergebnis der Subtraktion zurück
            return produkt;
        }

        /// <summary>
        /// Berrechnet zwei Zahlen mit ausgewählter operation. Note: Methode mit else if
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="zahl1"></param>
        /// <param name="zahl2"></param>
        /// <returns></returns>
        public float BerrechneMitIfElse(string operation, float zahl1, float zahl2)
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
    }
}
