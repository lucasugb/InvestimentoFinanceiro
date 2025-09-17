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

            if (unidade == "A") { }
            else if (unidade == "B")
            {
                periodo = periodo * 12;
            }

            double taxaReferencial = Poupanca.referencial;
            double selicAnual = TesouroSelic.taxaSelicAnual;
            decimal taxaPoupancaMensal;

            if (selicAnual > 0.085)
            {
                taxaPoupancaMensal = 0.005m + (decimal)taxaReferencial;
            }
            else
            {
                taxaPoupancaMensal = (decimal)taxaReferencial + ((decimal)Math.Pow(selicAnual, 1.0 / 12.0) * 0.7m);
            }
            decimal montante = investimentoInicial;
            decimal jurosAcumulado = 0;
            decimal totalInvestido = investimentoInicial;
            bool aviso = false;
            int mesSuperado = 0;
            Console.WriteLine("Mês\tJuros Mês\tTotal Investido\tJuros Acumulado\tMontante");

            for (int mes = 1; mes <= periodo; mes++)
            {
                decimal jurosMes = montante * taxaPoupancaMensal;
                montante += jurosMes;
                jurosAcumulado += jurosMes;
                montante += aporteMensal;
                totalInvestido += aporteMensal;
                Console.WriteLine($"{mes}\t{jurosMes:C}\t{totalInvestido:C}\t{jurosAcumulado:C}\t{montante:C}");

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
