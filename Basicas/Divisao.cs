using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Basicas
{
    internal class Divisao
    {
        public double Calcular(double Dividendo, double Divisor)
        {
            if(Divisor == 0) 
            {
                return 0;
            }
            else
            {
                return Dividendo / Divisor;
            }
        }
    }
}
