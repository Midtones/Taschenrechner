using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class ConsoleView
    {
        // Verknüft die Klasse RechnerModel mit der ConsoleView damit wir zugriff haben auf den Speicher vom Model.
        private RechnerModel model;
        
        // Propertys / Eigenschaften
        public bool BenutzerWillBeenden { get; private set; }

        // Construtor
        public ConsoleView(RechnerModel model)
        {
            this.model = model;
            this.BenutzerWillBeenden = false;
        }

        /// <summary>
        /// Legt die Textfarbe der Console fest, sowie die Cursor größe und bestimmt den Title des Fensters.
        /// </summary>
        /// <param name="Farbe"></param>
        /// <param name="cursorSize"></param>
        /// <param name="title"></param>
        public void ConsoleStyle(ConsoleColor Farbe, int cursorSize, string title)
        {
            Console.ForegroundColor = Farbe;
            Console.CursorSize = cursorSize;
            Console.Title = title;
        }

        /// <summary>
        /// Gibt einen Anweisungstext für den Benutzer in der Konsole aus und wandelt die Benutzereingabe vom Typ string in einen float um.
        /// </summary>
        /// <param name="ausgabeText"></param>
        /// <returns></returns>
        private float HoleZahlVomBenutzer()
        {
            string eingabe;
            float zahl;

            Console.Write("Gib eine Zahl ein: "); // gibt Text aus als Anweisung für den Nutzer.
            eingabe = Console.ReadLine(); // Die Konsoleneingabe wird in die Variable eingabe gespeichert.

            while (!float.TryParse(eingabe, out zahl)) // TryParse überprüft die Eingabe in der Variablen eingabe ob die Eingabe der Variablen Zahl die float ist entspricht.
            {
                Console.WriteLine("Du musst eine gültige Zahl eingeben!");
                Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
                eingabe = Console.ReadLine();
            }

            return zahl; //Ausgabe des eingegbenen Wertes.
        }

        /// <summary>
        /// Neue Eingabe wird geprüft ob der Benutzer beenden will oder das Ergebnis aus der alten Berrechnung wird zu model.Zahl1
        /// und die neue Eingabe wird Zahl2
        /// </summary>
        public void HoleFortlaufendeZahlVomBenutzer()
        {
            string eingabe;
            float zahl;

            eingabe = HoleNeueAktionVomBenutzer(); // Die Konsoleneingabe wird in die Variable eingabe gespeichert.
            if (eingabe.ToUpper() == "Q") // ToUpper konvertiert jede Konsolen eingabe in Großbuchstaben somit kann man q auch klein eingeben zum beenden.
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                model.Zahl1 = model.Ergebnis;

                while (!float.TryParse(eingabe, out zahl)) // siehe Methode HoleZahlVomBenutzer...
                {
                    Console.WriteLine("Du musst eine gültige Zahl eingeben!");
                    Console.Write("Bitte gib eine Zahl für die Berechnung ein (Zum beenden Q tippen):  ");
                    eingabe = Console.ReadLine();
                }

                model.Zahl2 = zahl;
            }

            do
            {
                if (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung)
                {
                    Console.WriteLine("FEHLER: Zahl muss größer als {0} und kleiner als {1} sein.", RechnerModel.UntererGrenzwert, RechnerModel.ObererGrenzwert);
                    model.Zahl2 = HoleZahlVomBenutzer();
                }
            }
            while (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung);
        }

        /// <summary>
        /// weitere Zahl Benutzereingabe
        /// </summary>
        /// <returns></returns>
        private string HoleNeueAktionVomBenutzer()
        {

            Console.Write("Gib eine weiter Zahl ein (Q zum beenden): "); // gibt Text aus als Anweisung für den Nutzer.
            string eingabe = Console.ReadLine(); // Die Konsoleneingabe wird in die Variable eingabe gespeichert.

            return eingabe;
        }

        /// <summary>
        /// Operator Benutzereingabe
        /// </summary>
        /// <param name="ausgabeText"></param>
        /// <returns></returns>
        private string HoleOperator()
        {
            string operation;
            do
            {
                Console.Write("gib die auszuführende Operation ein (+ - / *): "); // gibt Text aus als Anweisung für den Nutzer.
                operation = Console.ReadLine(); // Die Konsoleneingabe wirt in die Variable wert gespeichert.
                model.Operation = operation;

                if (model.AktuellerFehler == Fehler.UngueltigeOperation)
                {
                    Console.WriteLine("FEHLER ungültiger Operator!");
                }

            } while (model.AktuellerFehler == Fehler.UngueltigeOperation);

            return operation; //Ausgabe des eingegbenen Wertes.
        }

        /// <summary>
        /// Holt sich das Ergebnis aus dem RechnerModel und gibt den passenden Text aus.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="ergebnis"></param>
        public void GibErgebnisAus()
        {
            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe von {0} {1} {2} = {3}", model.Zahl1, model.Operation, model.Zahl2, model.Ergebnis);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz von {0} {1} {2} = {3}", model.Zahl1, model.Operation, model.Zahl2, model.Ergebnis);
                    break;

                case "/":
                    Console.WriteLine("Der Quotient von {0} {1} {2} = {3}", model.Zahl1, model.Operation, model.Zahl2, model.Ergebnis);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt von {0} {1} {2} = {3}", model.Zahl1, model.Operation, model.Zahl2, model.Ergebnis);
                    break;

                default:
                    Console.WriteLine("Dein Operator war ungültig! Du hast {0} eingegeben damit kann ich nicht rechnen!", model.Operation);
                    break;
            }
        }

        /// <summary>
        /// Holt sich alle benötigten Eingaben für die erste Berrechnung
        /// </summary>
        public void HoleBenutzerEingabenFürErsteBerechnung()
        {
            do
            {
                model.Zahl1 = HoleZahlVomBenutzer();
                if (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung)
                {
                    Console.WriteLine("FEHLER: Zahl muss größer als {0} und kleiner als {1} sein.", RechnerModel.UntererGrenzwert, RechnerModel.ObererGrenzwert);
                }
            }
            while (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung);


            model.Operation = HoleOperator();

            do
            {
                model.Zahl2 = HoleZahlVomBenutzer();
                if (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung)
                {
                    Console.WriteLine("FEHLER: Zahl muss größer als {0} und kleiner als {1} sein.", RechnerModel.UntererGrenzwert, RechnerModel.ObererGrenzwert);
                }
            }
            while (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung);
        }
    }
}
