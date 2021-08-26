using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weiss_Jessica_Millionenrechner
{
    class Berechnungen
    {
        public static double zinsberechnung(double Kapital, double Zins) 
        { 
            return Kapital + (Kapital / 100 * Zins);
        }
    }
}
