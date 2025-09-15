using Investimento_Financeiro.investimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInvestimentoFinanceiro
{
    [TestClass]
    public class TestePoupanca
    {
        [TestMethod]
        public void TesteCalcularPoupanca()
        {
            decimal investimentoInicial = 1000m;
            decimal aporteMensal = 500m;
            int periodo = 12;
            decimal montante;
            string unidade = "A";

            montante = Poupanca.CalculoPoupanca(investimentoInicial, aporteMensal, periodo, unidade);

            Assert.AreEqual(7309.54m, Math.Round(montante, 2));

        }
    }
}
