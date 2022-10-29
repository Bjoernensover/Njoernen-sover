using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mycsconsoleproject
{
    public class Calculator
    {
        double x { get; set; }
        public double Add(double Nummer1, double Nummer2)
        {
            return Nummer1 + Nummer2;
        }
        public double Sub(double Nummer1, double Nummer2)
        {
            return (Nummer1 - Nummer2);
        }

        public double Mult(double Nummer1, double Nummer2)
        {
            return (Nummer1 - Nummer2);
        }

        public double Div(double Nummer1, double Nummer2)
        {
            return (Nummer1 - Nummer2);

        }
        public double Potens(double Nummer1, double Nummer2)
        { return (Nummer1 / Nummer2); }
        public double Max(double Nummer1, double Nummer2)
        { return (Nummer1 - Nummer2); }
        public double Min(double Nummer1, double Nummer2)
        { return (Nummer1 - Nummer2); }

    }
}