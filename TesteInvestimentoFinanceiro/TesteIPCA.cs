using Investimento_Financeiro.investimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInvestimentoFinanceiro
{
    public class TesteIPCA
    {
        [TestMethod]
        public void TesteCalcularIPCA()
        {
            decimal investimentoInicial = 1000m;
            decimal aporteMensal = 500m;
            int periodo = 12;
            decimal montante;
            string unidade = "A";

            montante = TesouroSelic.CalculoSelic(investimentoInicial, aporteMensal, periodo, unidade);

            Assert.AreEqual(7454.72m, Math.Round(montante, 2));

        }
    }
}
