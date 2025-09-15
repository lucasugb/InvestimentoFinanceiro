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
        public static decimal CalculoSelic(decimal investimentoInicial, decimal aporteMensal, int periodo, string unidade)
        {
            if (unidade == "A") { }
            else if (unidade == "B")
            {
                periodo = periodo * 12;
            }

            decimal montante = investimentoInicial;
            decimal jurosAcumulado = 0;
            decimal totalInvestido = investimentoInicial;
            decimal taxaMensal = (decimal)Math.Pow((1 + taxaSelicAnual), 1.0 / 12.0) - 1;
            bool aviso = false;
            Console.WriteLine("Mês\tJuros Mês\tTotal Investido\tJuros Acumulado\tMontante");

            for (int mes = 1; mes <= periodo; mes++)
            {
                decimal jurosMes = montante * taxaMensal;
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