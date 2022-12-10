using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private int kilometerstand;
        private double tankinhalt;
        private double verbrauchPro100Kilometern;

        public Auto(int kilometerstand, double tankinhalt, double verbrauchPro100Kilometern)
        {
            this.kilometerstand = kilometerstand;
            this.tankinhalt = tankinhalt;
            this.verbrauchPro100Kilometern = verbrauchPro100Kilometern;
        }

        public void Fahren(int streckeInKilometer)
        {
            if (streckeInKilometer > 0)
            {
            kilometerstand += streckeInKilometer;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Negativ Strecke nicht möglich");
            }
            
        }

        public double Tank(double tankinhalt,double verbrauchPro100Kilometern)
        {
            tankinhalt = tankinhalt - verbrauchPro100Kilometern;
            return tankinhalt;
        }

        public int Kilometerstand
        {
            get { return kilometerstand; }
        }
    }
}
