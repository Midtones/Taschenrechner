using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        // Verknüft die Klassen.
        private RechnerModel model;
        private ConsoleView view;

        // Constructor
        public AnwendungsController(RechnerModel model, ConsoleView view)
        {
            this.model = model;
            this.view = view;
        }

        public void TaschenrechnerAusführen()
        {
            while (!view.BenutzerWillBeenden)
            {
                // Benutzereingaben werden abgefragt.
                view.HoleBenutzerEingaben();

                // Berrechnung wird ausgeführt und Ausgegeben. Gelöst mit Switch
                model.BerrechneMitSwitchCase();

                // Ausgabe
                view.GibErgebnisAus();
            }
 
        }

    }
}
