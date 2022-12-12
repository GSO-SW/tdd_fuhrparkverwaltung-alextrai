using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System;
using System.Data;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
        public void Fahren_SteigertKilometerstand()
        {
            //Arrange
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fahren_NegativeKilometerWerdenIgnoriert()
        {
        //Arrange
        int kilometerstand = 10;
        Auto a = new Auto(kilometerstand);
        int streckeInKilometern = -1;
        //Act
        a.Fahren(streckeInKilometern);
        }

        [TestMethod]

        public void Fahren_VerbrauchtTankinhalt()
        {
            //Arrange
            int kilometerstand = 0;
            double tankinhalt = 10;
            double verbrauchPro100Kilometern = 5.7;
            Auto a = new Auto(kilometerstand,tankinhalt, verbrauchPro100Kilometern);


            //Act
            a.Fahren(100);

            //Assert
            Assert.AreEqual(4,3,a.Tankinhalt);

        }
    }
}
