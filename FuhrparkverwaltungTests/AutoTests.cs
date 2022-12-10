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
            double tankinhalt = 0;
            double verbrauchPro100Kilometern = 0;
            Auto a = new Auto(kilometerstand, tankinhalt, verbrauchPro100Kilometern);
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
            double tankinhalt = 0;
            double verbrauchPro100Kilometern = 0;
            Auto b = new Auto(kilometerstand,tankinhalt,verbrauchPro100Kilometern);
        int streckeInKilometern = -1;
        //Act
        b.Fahren(streckeInKilometern);
        }

        [TestMethod]

        public void Tank_VerbrauchPro100Kilometern()
        {
            //Arrange
            int kilometerstand = 0;
            double tankinhalt = 10;
            double verbrauchPro100Kilometern = 5.7;
            Auto c = new Auto(kilometerstand,tankinhalt, verbrauchPro100Kilometern);


            //Act
            double neuerTankinhalt = c.Tank(tankinhalt, verbrauchPro100Kilometern);

            //Assert
            Assert.AreEqual(tankinhalt - verbrauchPro100Kilometern, neuerTankinhalt);

        }
    }
}
