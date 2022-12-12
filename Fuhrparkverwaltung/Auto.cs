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

        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
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

        public int Kilometerstand
        {
            get { return kilometerstand; }
        }
    }
}
