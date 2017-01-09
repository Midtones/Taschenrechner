﻿using System;
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

        // Construtor
        public ConsoleView(RechnerModel model)
        {
            this.model = model;
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
            Console.Title = "title";
        }

        /// <summary>
        /// Gibt einen Anweisungstext für den Benutzer in der Konsole aus und wandelt die Benutzereingabe vom Typ string in einen float um.
        /// </summary>
        /// <param name="ausgabeText"></param>
        /// <returns></returns>
        private float HoleZahlVomBenutzer()
        {
            Console.Write("Gib eine Zahl ein: "); // gibt Text aus als Anweisung für den Nutzer.
            string wert = Console.ReadLine(); // Die Konsoleneingabe wirt in die Variable wert gespeichert.
            float wertZuZahl = float.Parse(wert); // Der eingegeben Wert string wird in einen float gewandelt.

            return wertZuZahl; //Ausgabe des eingegbenen Wertes.
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
        /// Holt sich alle benötigten Daten für die Berrechnung
        /// </summary>
        public void HoleBenutzerEingaben()
        {
            model.Zahl1 = HoleZahlVomBenutzer();
            model.Operation = HoleOperator();
            model.Zahl2 = HoleZahlVomBenutzer();
        }

        /// <summary>
        /// Hält die Kommandozeile offen und wartet auf eine Tasten eingabe.
        /// </summary>
        public void WarteAufBenutzerEingabe(string ausgabeText)
        {
            Console.WriteLine(ausgabeText);
            Console.ReadLine();
        }
    }
}
