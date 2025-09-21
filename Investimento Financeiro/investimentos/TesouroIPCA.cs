using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento_Financeiro.investimentos
{
    public class TesouroIPCA
    {
        public static double FixaAnual = 0.0753;
        public static double ipcaAnual = 0.0445;
        public static decimal CalculoIPCA(decimal investimentoInicial, decimal aporteMensal, int periodo, string unidade)
        {
            if (unidade == "B")
            {
                periodo = periodo * 12;
            }

            decimal taxaFixaMensal = (decimal)Math.Pow(1 + (TesouroIPCA.FixaAnual), 1.0 / 12.0) - 1;
            decimal ipca = (decimal)Math.Pow((1 + TesouroIPCA.ipcaAnual), 1.0 / 12.0) - 1; ;
            decimal montante = investimentoInicial;
            decimal jurosAcumulado = 0;
            decimal totalInvestido = investimentoInicial;
            decimal taxaMensal = (1 + taxaFixaMensal) * (1 + ipca) - 1;
            bool aviso = false;
            int mesSuperado = 0;
            Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-20}", "Mês", "Juros Mês", "Total Investido", "Juros Acumulado", "Montante");

            for (int mes = 1; mes <= periodo; mes++)
            {
                decimal jurosMes = montante * taxaMensal;
                montante += jurosMes;
                jurosAcumulado += jurosMes;
                montante += aporteMensal;
                totalInvestido += aporteMensal;
                Console.WriteLine("{0,-5} {1,-20:C2} {2,-20:C2} {3,-20:C2} {4,-20:C2}", mes, jurosMes, totalInvestido, jurosAcumulado, montante);

                if (aviso == false && jurosMes > aporteMensal)
                {
                    mesSuperado = mes;
                    aviso = true;
                }

                
            }
            if (aviso == true)
                Console.WriteLine($"O juros mensal ultrapassou o aporte mensal no {mesSuperado}º mês.");

            return montante;
        }
    }
}
