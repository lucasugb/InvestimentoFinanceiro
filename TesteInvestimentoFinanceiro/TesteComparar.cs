using Investimento_Financeiro.investimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInvestimentoFinanceiro
{
    [TestClass]
    public class TesteComparar
    {
        [TestMethod]
        public void TesteComparacao()
        {
            decimal investimentoInicial = 1000m;
            decimal aporteMensal = 500m;
            int periodo = 12;
            decimal montanteSelic;
            decimal montanteIPCA;
            decimal montantePoupanca;
            decimal montanteCDB;
            string unidade = "A";

            montanteIPCA = TesouroIPCA.CalculoIPCA(investimentoInicial, aporteMensal, periodo, unidade);
            montanteSelic = TesouroSelic.CalculoSelic(investimentoInicial, aporteMensal, periodo, unidade);
            montantePoupanca = Poupanca.CalculoPoupanca(investimentoInicial, aporteMensal, periodo, unidade);
            montanteCDB = CDB.CalculoCDB(investimentoInicial, aporteMensal, periodo, unidade);

            Assert.AreEqual(7475.98m, Math.Round(montanteCDB, 2));
            Assert.AreEqual(7309.54m, Math.Round(montantePoupanca, 2));
            Assert.AreEqual(7548.48m, Math.Round(montanteSelic, 2));
            Assert.AreEqual(7454.72m, Math.Round(montanteIPCA, 2));

        }
    }
}
