using Investimento_Financeiro.TesouroSelic;
int opcao;
do
{
    Console.WriteLine("[0] - Sair");
    Console.WriteLine("[1] - Tesouro Selic");
    Console.WriteLine("[2]");
    Console.WriteLine("[3]");
    Console.WriteLine("[4]");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe o Investimento Inicial: ");
            decimal investimentoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o Aporte Mensal: ");
            decimal aporteMensal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o período em meses: ");
            int periodo = Convert.ToInt32(Console.ReadLine());
            TesouroSelic.CalculoSelic(investimentoInicial, aporteMensal, periodo);
            break;
    }
} while (opcao != 0);