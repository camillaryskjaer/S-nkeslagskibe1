using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Undgå at bruge øæ og å
namespace Sænkeslagskibe1
{
    internal abstract class Ship
    {

        // Super ship class with shiplife/value
        protected internal int shipValue;

        public int ShipValue
        {
            get { return shipValue; }
            private set { shipValue = value; }
        } 
//Hvorfor default constructor her?
        protected internal Ship()
        {

        }
    }
}
