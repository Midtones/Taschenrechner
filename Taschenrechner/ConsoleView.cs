using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
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
            Console.Write("Gib eine Zahl ein: "); // gibt Text aus als Anweisung für den Nutzer.
            eingabe = Console.ReadLine(); // Die Konsoleneingabe wird in die Variable eingabe gespeichert.
            
            return Convert.ToSingle(eingabe); //Ausgabe des eingegbenen Wertes.
        }

        /// <summary>
        /// Neue Eingabe wird geprüft ob der Benutzer beenden will oder das Ergebnis aus der alten Berrechnung wird zu model.Zahl1
        /// und die neue Eingabe wird Zahl2
        /// </summary>
        public void HoleFortlaufendeZahlVomBenutzer()
        {
            string eingabe;

            eingabe = HoleNeueZahlVomBenutzer(); // Die Konsoleneingabe wird in die Variable eingabe gespeichert.
            if (eingabe == "Q")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                model.Zahl1 = model.Ergebnis;
                model.Zahl2 = Convert.ToSingle(eingabe);
            }
        }

        /// <summary>
        /// weitere Zahl Benutzereingabe
        /// </summary>
        /// <returns></returns>
        private string HoleNeueZahlVomBenutzer()
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
            Console.Write("gib die auszuführende Operation ein (+ - / *): "); // gibt Text aus als Anweisung für den Nutzer.
            string wert = Console.ReadLine(); // Die Konsoleneingabe wirt in die Variable wert gespeichert.

            return wert; //Ausgabe des eingegbenen Wertes.
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
            model.Zahl1 = HoleZahlVomBenutzer();
            model.Operation = HoleOperator();
            model.Zahl2 = HoleZahlVomBenutzer();
        }
    }
}
