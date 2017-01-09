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
            RechnerModel rechnerKlasse = new RechnerModel();
            ConsoleView viewKlasse = new ConsoleView(rechnerKlasse);
            AnwendungsController controllerKlasse = new AnwendungsController(rechnerKlasse, viewKlasse);

            // Consolen aussehen wird festgelegt.
            viewKlasse.ConsoleStyle(ConsoleColor.Cyan, 100, "Taschenrechner");

            controllerKlasse.Ausführen();

        }
    }
}
