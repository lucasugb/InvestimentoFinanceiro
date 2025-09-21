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
            double taxaMensalSelic = Math.Pow((1 + TesouroSelic.taxaSelicAnual), 1.0 / 12.0) - 1;
            decimal w = (decimal)Math.Pow((1 + taxaMensalSelic), periodo);
            decimal montanteSelic = (investimentoInicial * w) + (aporteMensal * ((w - 1)/(decimal)taxaMensalSelic));

            double ipcaMensal = Math.Pow((1 + TesouroIPCA.ipcaAnual), 1.0 / 12.0) - 1;
            double fixaMensal = Math.Pow((1 + TesouroIPCA.FixaAnual), 1.0 / 12.0) - 1;
            double taxaIpcaTotalMensal = (1 + fixaMensal) * (1 + ipcaMensal) - 1;
            decimal x = (decimal)Math.Pow((1 + taxaIpcaTotalMensal), periodo);
            decimal montanteIpca = (investimentoInicial * x) + (aporteMensal * ((x - 1)/(decimal) taxaIpcaTotalMensal));
            double cdiAnual = CDB.cdi;
            double taxaMensalCdi = Math.Pow((1 + cdiAnual), 1.0 / 12.0) - 1;
            decimal y = (decimal)Math.Pow((1 + taxaMensalCdi), periodo);
            decimal montanteCDB = (investimentoInicial * y) + (aporteMensal * ((y - 1) / (decimal)taxaMensalCdi));

            double taxaPoupançaMensal;
            if (TesouroSelic.taxaSelicAnual > 0.085)
            {
                taxaPoupançaMensal = 0.005 + Poupanca.referencial;
            }
            else
            {
                taxaPoupançaMensal = Poupanca.referencial + taxaMensalSelic;
            }
            decimal z = (decimal)Math.Pow((1 + taxaPoupançaMensal), periodo);
            decimal montantePoupanca = (investimentoInicial * z) + (aporteMensal * ((z - 1) / (decimal)taxaPoupançaMensal));


            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20}", "Montante Selic", "Montante IPCA+", "Montante CDB", "Montante Poupança");
            Console.WriteLine("{0,-20:C2} {1,-20:C2} {2,-20:C2} {3,-20:C2}", montanteSelic, montanteIpca, montanteCDB, montantePoupanca);
        }
    }
}

