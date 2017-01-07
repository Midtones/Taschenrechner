using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        /// <summary>
        /// Gibt einen Anweisungstext für den Benutzer in der Konsole aus und wandelt die Benutzereingabe vom Typ string in einen float um.
        /// </summary>
        /// <param name="ausgabeText"></param>
        /// <returns></returns>
        public float HoleBenutzerdaten(string ausgabeText)
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
        public string HoleOperator(string ausgabeText)
        {
            Console.Write(ausgabeText); // gibt Text aus als Anweisung für den Nutzer.
            string wert = Console.ReadLine(); // Die Konsoleneingabe wirt in die Variable wert gespeichert.

            return wert; //Ausgabe des eingegbenen Wertes.
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
