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

        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public void Fahren(int streckeInKilometer)
        {
            kilometerstand += streckeInKilometer;
        }

        public int Kilometerstand
        {
            get { return kilometerstand; }
        }
    }
}
