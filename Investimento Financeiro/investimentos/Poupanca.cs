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
        public static decimal CalculoPoupanca(decimal investimentoInicial, decimal aporteMensal, int periodo, string unidade)
        {

            if (unidade == "A") { }
            else if (unidade == "B")
            {
                periodo = periodo * 12;
            }
            else
            {
                Console.WriteLine("Vou fingir que você escolheu A :)");
            }

            double taxaReferencial = 0.0017;
            double selicAnual = TesouroSelic.taxaSelicAnual;
            decimal taxaPoupançaMensal = 0;

            if (selicAnual > 0.085)
            {
                taxaPoupançaMensal = 0.005m + (decimal)taxaReferencial;
            }
            else
            {
                taxaPoupançaMensal = (decimal)Math.Pow(selicAnual + taxaReferencial, 1.0 / 12.0);
            }
            decimal montante = investimentoInicial;
            decimal jurosAcumulado = 0;
            decimal totalInvestido = investimentoInicial;
            bool aviso = false;
            Console.WriteLine("Mês\tJuros Mês\tTotal Investido\tJuros Acumulado\tMontante");

            for (int mes = 1; mes <= periodo; mes++)
            {
                decimal jurosMes = montante * taxaPoupançaMensal;
                montante += jurosMes;
                jurosAcumulado += jurosMes;
                montante += aporteMensal;
                totalInvestido += aporteMensal;

                if (!aviso && jurosMes > aporteMensal)
                {
                    Console.WriteLine($"O juros mensal ultrapassou o aporte mensal");
                    aviso = true;
                }

                Console.WriteLine($"{mes}\t{jurosMes:C}\t{totalInvestido:C}\t{jurosAcumulado:C}\t{montante:C}");
            }
            return montante;
        }
    }
}
