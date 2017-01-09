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
            // holt Benutzereingabe für erste Berrechnung
            view.HoleBenutzerEingabenFürErsteBerechnung();

            // Berrechnung
            model.BerrechneMitSwitchCase();

            // Ausgabe
            view.GibErgebnisAus();

            // neue Zahl oder Beenden?
            view.HoleFortlaufendeZahlVomBenutzer();


            while (!view.BenutzerWillBeenden)
            {
                // neu Berrechnung
                model.BerrechneMitSwitchCase();

                // Ausgabe
                view.GibErgebnisAus();

                // neue Zahl oder Beenden?
                view.HoleFortlaufendeZahlVomBenutzer();
            }
 
        }

    }
}
