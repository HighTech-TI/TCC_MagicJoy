using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Objetos
{
    class Folha
    {
        public decimal CalcularVT(decimal salario)
        {
            decimal total = salario * 0.06m;
            return total;
        }

        public decimal CalcularInss(decimal salario)
        {
            decimal total = 0;

            if (salario <= 1751.81m)
            {
                total = salario * 0;
            }
            else if (salario == 1751.81m)
            {
                total = salario * 0.08m;
            }

            if (salario == 1751.82m && salario <= 2919.72m)
            {
                total = salario * 0.09m;
            }
            else if (salario == 2919.73m && salario <= 5839.45m)
            {
                total = salario * 0.11m;
            }

            return total;
        }
    }
}
