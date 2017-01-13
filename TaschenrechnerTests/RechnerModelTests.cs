using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taschenrechner.Tests
{
    [TestClass]
    public class RechnerModelTests
    {
        [TestMethod]
        public void Berechne_DivisionDurchNull_ErgibtNaN()
        {
            RechnerModel model = new RechnerModel();

            model.Zahl1 = 10;
            model.Zahl2 = 0;
            model.Operation = "/";

            model.BerrechneMitSwitchCase();

            Assert.AreEqual(float.PositiveInfinity,model.Ergebnis);


        }
    }
}
