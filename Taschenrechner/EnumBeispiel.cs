using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum AutoMarke
    {
        porsche = 1,
        audi
    }

    public class EnumBeispiel
    {
        const int porsche = 1;
        const int audi = 2;

        public static void Ausfuehren()
        {
            AutoMarke meinAuto = AutoMarke.audi;

            GibAutoMarkeAus(meinAuto);
        }

        private static void GibAutoMarkeAus(AutoMarke marke)
        {
            string ausgabe;

            switch (marke)
            {
                case AutoMarke.porsche:
                    ausgabe = "Du fährst einen Prosche";
                    break;
                case AutoMarke.audi:
                    ausgabe = "Du fährst einen BMW";
                    break;
                default:
                    ausgabe = "Marke kenn ich nicht!";
                    break;
            }

            Console.WriteLine(ausgabe);

        }
    }
}
