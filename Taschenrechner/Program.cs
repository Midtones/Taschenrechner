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
            // neue Objekte von den Klassen werden angelegt und ggf. mit einander verknüpft.
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);

            // Consolen aussehen wird festgelegt.
            view.ConsoleStyle(ConsoleColor.Cyan, 100, "Taschenrechner");

            // Benutzereingaben werden abgefragt.
            float zahl1 = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperator();
            float zahl2 = view.HoleZahlVomBenutzer();
            
            // Berrechnung wird ausgeführt und Ausgegeben. Gelöst mit Switch
            model.BerrechneMitSwitchCase(operation, zahl1, zahl2);

            // Ausgabe
            view.GibErgebnisAus(zahl1, operation, zahl2);
            view.WarteAufBenutzerEingabe("Zum beenden einfach die EINGABETASTE Drücken!");
        }
    }
}
