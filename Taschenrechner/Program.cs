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
            ConsoleView view = new ConsoleView();
            float zahl1 = view.HoleBenutzerdaten("Gib die erste Zahl ein: ");
            float zahl2 = view.HoleBenutzerdaten("Gib die zweite Zahl ein: ");
            string operation = view.HoleOperator("gib die auszuführende Operation ein (+ - / *): ");

            // Berrechnung wird ausgeführt und Ausgegeben. Gelöst mit Switch
            RechnerModel model = new RechnerModel();
            model.BerrechneMitSwitchCase(operation, zahl1, zahl2);
            Console.WriteLine("Das Ergebnis {1} {0} {2} = {3}",operation ,zahl1, zahl2, model.Ergebnis);

            // Kommandozeile wartet auf eine Benutzereingabe
            view.WarteAufBenutzerEingabe("Zum beenden einfach die EINGABETASTE Drücken!");
        }
    }
}
