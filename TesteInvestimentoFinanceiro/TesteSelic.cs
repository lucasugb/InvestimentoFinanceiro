using Investimento_Financeiro.investimentos;

namespace TesteInvestimentoFinanceiro
{
    [TestClass]
    public class TesteSelic
    {
        [TestMethod]
        public void TesteCalcularSelic()
        {
            decimal investimentoInicial = 1000m;
            decimal aporteMensal = 500m;
            int periodo = 12;
            decimal montante;
            string unidade = "A";

            montante = TesouroSelic.CalculoSelic(investimentoInicial, aporteMensal, periodo, unidade);

            Assert.AreEqual(7548.48m, Math.Round(montante, 2));


        }
    }
}
