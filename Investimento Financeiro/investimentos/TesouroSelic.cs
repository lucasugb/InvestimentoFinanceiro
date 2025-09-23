using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento_Financeiro.investimentos
{
    public class TesouroSelic
    {
        public static double taxaSelicAnual = 0.1490;
        public static double taxaMensal = Math.Pow((1 + taxaSelicAnual), 1.0 / 12.0) - 1;
        public static decimal CalculoSelic(decimal investimentoInicial, decimal aporteMensal, int periodo, string unidade)
        {
            if (unidade == "B")
            {
                periodo = periodo * 12;
            }
            decimal montante = investimentoInicial;
            decimal jurosAcumulado = 0;
            decimal totalInvestido = investimentoInicial;
            
            bool aviso = false;
            int mesSuperado = 0;
            Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-20}", "Mês", "Juros Mês", "Total Investido", "Juros Acumulado", "Montante");

            for (int mes = 1; mes <= periodo; mes++)
            {
                decimal jurosMes = montante * (decimal)taxaMensal;
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