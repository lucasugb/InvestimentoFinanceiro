using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento_Financeiro.TesouroSelic
{
    public class TesouroSelic
    {
        public static decimal Calcular(double capitalInicial, double taxaAnual, int periodo)
        {
            double montante = capitalInicial * Math.Pow(1 + taxaAnual, periodo);
            return (decimal)montante;
        }
    }
}
