using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento_Financeiro.investimentos
{
    public class Comparar
    {
        public static decimal Comparacao(decimal investimentoInicial, decimal aporteMensal, int periodo, string unidade)
        {
            if (unidade == "A") { }
            else if (unidade == "B")
            {
                periodo = periodo * 12;
            }
            double selicAnual = TesouroSelic.taxaSelicAnual;
            double taxaMensalSelic = Math.Pow((1 + selicAnual), 1.0 / 12.0) - 1;
            decimal w = (decimal)Math.Pow((1 + taxaMensalSelic), periodo);
            decimal montanteSelic = (investimentoInicial * w) + (aporteMensal * ((w - 1)/(decimal)taxaMensalSelic));

            double ipcaAnual = TesouroIPCA.ipcaAnual;
            double ipcaMensal = Math.Pow((1 + ipcaAnual), 1.0 / 12.0) - 1;
            double fixaAnual = TesouroIPCA.FixaAnual;
            double fixaMensal = Math.Pow((1 + fixaAnual), 1.0 / 12.0) - 1;
            double taxaIpcaTotalMensal = (1 + fixaMensal) * (1 + ipcaMensal) - 1;
            decimal x = (decimal)Math.Pow((1 + taxaIpcaTotalMensal), periodo);
            decimal montanteIpca = (investimentoInicial * x) + (aporteMensal * ((x - 1)/(decimal) taxaIpcaTotalMensal));

            double cdiAnual = CDB.cdi;
            double taxaMensalCdi = Math.Pow((1 + cdiAnual), 1.0 / 12.0) - 1;
            decimal y = (decimal)Math.Pow((1 + taxaMensalCdi), periodo);
            decimal montanteCDB = (investimentoInicial * y) + (aporteMensal * ((y - 1) / (decimal)taxaMensalCdi));

            double taxaReferencial = Poupanca.referencial;
            double taxaPoupançaMensal;
            if (TesouroSelic.taxaSelicAnual > 0.085)
            {
                taxaPoupançaMensal = 0.005 + taxaReferencial;
            }
            else
            {
                taxaPoupançaMensal = taxaReferencial + taxaMensalSelic;
            }
            decimal z = (decimal)Math.Pow((1 + taxaPoupançaMensal), periodo);
            decimal montantePoupanca = (investimentoInicial * z) + (aporteMensal * ((z - 1) / (decimal)taxaPoupançaMensal));


            Console.WriteLine($"MONTANTE SELIC\tMONTANTE IPCA\tMONTANTE CDB\tMONTANTE POUPANÇA");
            Console.WriteLine($"{montanteSelic:C}\t{montanteIpca:C}\t{montanteCDB:C}\t{montantePoupanca:C}");
            return 0;
        }
    }
}

