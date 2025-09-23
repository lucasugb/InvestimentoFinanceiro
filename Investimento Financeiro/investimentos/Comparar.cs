using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento_Financeiro.investimentos
{
    public class Comparar
    {
        public static void Comparacao(decimal investimentoInicial, decimal aporteMensal, int periodo, string unidade)
        {
            if (unidade == "B")
            {
                periodo = periodo * 12;
            }
            decimal w = (decimal)Math.Pow((1 + TesouroSelic.taxaMensal), periodo);
            decimal montanteSelic = (investimentoInicial * w) + (aporteMensal * ((w - 1)/(decimal)TesouroSelic.taxaMensal));


            decimal x = (decimal)Math.Pow((1 + TesouroIPCA.taxaMensal), periodo);
            decimal montanteIpca = (investimentoInicial * x) + (aporteMensal * ((x - 1)/(decimal)TesouroIPCA.taxaMensal));

            decimal y = (decimal)Math.Pow((1 + CDB.taxaCdiMensal), periodo);
            decimal montanteCDB = (investimentoInicial * y) + (aporteMensal * ((y - 1) / (decimal)CDB.taxaCdiMensal));

            double taxaPoupançaMensal;
            if (TesouroSelic.taxaSelicAnual > 0.085)
            {
                taxaPoupançaMensal = 0.005 + Poupanca.referencial;
            }
            else
            {
                taxaPoupançaMensal = 0.7 * TesouroSelic.taxaMensal + Poupanca.referencial;
            }
            decimal z = (decimal)Math.Pow((1 + taxaPoupançaMensal), periodo);
            decimal montantePoupanca = (investimentoInicial * z) + (aporteMensal * ((z - 1) / (decimal)taxaPoupançaMensal));


            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20}", "Montante Selic", "Montante IPCA+", "Montante CDB", "Montante Poupança");
            Console.WriteLine("{0,-20:C2} {1,-20:C2} {2,-20:C2} {3,-20:C2}", montanteSelic, montanteIpca, montanteCDB, montantePoupanca);
        }
    }
}

