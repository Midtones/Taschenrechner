using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private RechnerModel model;
        private ConsoleView view;

        // Constructor
        public AnwendungsController(RechnerModel model, ConsoleView view)
        {
            this.model = model;
            this.view = view;
        }

        public void Ausführen()
        {
            // Benutzereingaben werden abgefragt.
            view.HoleBenutzerEingaben();

            // Berrechnung wird ausgeführt und Ausgegeben. Gelöst mit Switch
            model.BerrechneMitSwitchCase();

            // Ausgabe
            view.GibErgebnisAus();
            view.WarteAufBenutzerEingabe("Zum beenden einfach die EINGABETASTE Drücken!");
        }

    }
}
