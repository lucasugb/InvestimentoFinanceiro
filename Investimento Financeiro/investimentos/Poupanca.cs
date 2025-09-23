using Investimento_Financeiro.investimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento_Financeiro.investimentos
{

    public class Poupanca
    {
        public static double referencial = 0.0017;
        public static decimal CalculoPoupanca(decimal investimentoInicial, decimal aporteMensal, int periodo, string unidade)
        {
            if (unidade == "B")
            {
                periodo = periodo * 12;
            }

            double selicMensal = Math.Pow((1 + TesouroSelic.taxaSelicAnual),1.0 / 12.0) - 1;
            decimal taxaPoupancaMensal;

            if (selicMensal > 0.085)
            {
                taxaPoupancaMensal = 0.005m + (decimal)Poupanca.referencial;
            }
            else
            {
                taxaPoupancaMensal = (decimal)selicMensal * 0.7m + (decimal)Poupanca.referencial ;
            }
            decimal montante = investimentoInicial;
            decimal jurosAcumulado = 0;
            decimal totalInvestido = investimentoInicial;
            bool aviso = false;
            int mesSuperado = 0;
            Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-20}", "Mês", "Juros Mês", "Total Investido", "Juros Acumulado", "Montante");

            for (int mes = 1; mes <= periodo; mes++)
            {
                decimal jurosMes = montante * taxaPoupancaMensal;
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
