using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public enum Fehler // Eine enum wird benötigt um eingen Datentypen zu erstellen.
    {
        Keiner,
        GrenzwertUeberschreitung,
        UngueltigeOperation
    }

    public class RechnerModel 
    {

        /// <summary>
        /// Constructor legt fest welche Variablen für die Klasse festgelgt werden müssen, damit die Methoden arbeiten können.
        /// </summary>
        // Achtung!
        // Dieser Constructor hat keine festgelegten Variablen!
        // So sieht ein normaler Construtor aus:
        // public RechnerModel(float ergebnis)
        // {
        //      Ergebnis = ergebnis;
        // }
        public RechnerModel()
        {
            Ergebnis = 0F;
            Operation = "unbekannt";
            AktuellerFehler = Fehler.Keiner;
        }

        // Property / Eigenschaft **** Shortcut **** "prob" tippen und zweimal "Tab-Taste".
        public float Ergebnis { get; private set; } // get und set zum abfragen der Eigenschaft. private verhindert das ändern von aussen!

        private string operation = "ungueltig";
        public string Operation
        {
            get
            {
                return operation;
            }

            set
            {
                // Wir ändern den Wert der Eigenschaft nur, wenn ein anderer Wert
                // zugewiesen wird
                if (value != operation)
                {
                    switch (value)
                    {
                        case "+":
                        case "-":
                        case "/":
                        case "*":
                            // Es wurde eine gültige Operation übergeben. Daher können wir
                            // den Fehler zurücksetzen ...
                            if (AktuellerFehler == Fehler.UngueltigeOperation)
                            {
                                AktuellerFehler = Fehler.Keiner;
                            }
                            // ... und den neuen Operator verwenden
                            operation = value;
                            break;

                        default:
                            // Die übergebene Operation wird nicht unterstützt. Daher wird 
                            // angezeigt, dass ein Fehler anliegt und auch die operation zeigt
                            // an, dass etwas nicht stimmt.
                            operation = "ungueltig";
                            AktuellerFehler = Fehler.UngueltigeOperation;
                            break;
                    }
                }
            }
        }

        private float zahl1 = 0;
        public float Zahl1
        {
            get { return zahl1; }
            set
            {
                if (zahl1 != value)
                {
                    AktuellerFehler = GrenzwertCheck(value);
                    zahl1 = value;
                }
            }
        }

        private float zahl2 = 0;
        public float Zahl2
        {
            get { return zahl2; }
            set
            {
                if (zahl2 != value)
                {
                    AktuellerFehler = GrenzwertCheck(value);
                    zahl2 = value;
                }
            }
        }

        public Fehler AktuellerFehler { get; private set; }
        public static float ObererGrenzwert { get { return 100.0F; } }
        public static float UntererGrenzwert { get { return -10.0F; } }



        /// <summary>
        /// Die Grenzwerte werden überprüft.
        /// </summary>
        /// <param name="zahl"></param>
        /// <returns></returns>
        private Fehler GrenzwertCheck(float zahl)
        {
            Fehler resultat = Fehler.Keiner;

            if ((zahl < UntererGrenzwert) || (zahl > ObererGrenzwert))
            {
                resultat = Fehler.GrenzwertUeberschreitung;
            }

            return resultat;
        }

        public void FehlerZurueckSetzen()
        {
            AktuellerFehler = Fehler.Keiner;
        }

        /// <summary>
        /// Berrechnet zwei Zahlen mit ausgewählter operation. Note: Methode mit SwitchCase
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="zahl1"></param>
        /// <param name="zahl2"></param>
        public void BerrechneMitSwitchCase()
        {
            if (AktuellerFehler != Fehler.Keiner)
            {
                return;
            }

            switch (this.Operation)
            {
                case "+":
                    Ergebnis = Addieren(this.Zahl1, this.Zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                case "-":
                    Ergebnis = Subtrahieren(this.Zahl1, this.Zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                case "/":
                    Ergebnis = Division(this.Zahl1, this.Zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                case "*":
                    Ergebnis = Multiplikation(this.Zahl1, this.Zahl2); // Ergebnis berechnet die beiden Zahlen.
                    break;

                default:
                    Console.WriteLine("Dein Operator war ungültig! Du hast {0} eingegeben damit kann ich nicht rechnen!", this.Operation);
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
        public void BerrechneMitIfElse(string operation, float zahl1, float zahl2)
        {
            // Es wird geprüft ob ein Fehler vorliegt wenn Ja wird hier abgebrochen...!
            if (AktuellerFehler != Fehler.Keiner)
            {
                return;
            }

            // Berechnung wird ausgeführt gelöst mit if und else if
            else if (operation == "+")
            {
                Ergebnis = Addieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            }
            else if (operation == "-")
            {
                Ergebnis = Subtrahieren(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            }
            else if (operation == "/")
            {
                Ergebnis = Division(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            }
            else if (operation == "*")
            {
                Ergebnis = Multiplikation(zahl1, zahl2); // Ergebnis berechnet die beiden Zahlen.
            }
            else
            {
                Console.WriteLine("Dein Operator war ungültig!");
            }
        }
    }
}
