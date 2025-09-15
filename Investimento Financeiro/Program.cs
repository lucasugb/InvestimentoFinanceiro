using Investimento_Financeiro.investimentos;
int opcao;
do
{
    Console.WriteLine("[0] - Sair");
    Console.WriteLine("[1] - Tesouro Selic");
    Console.WriteLine("[2] - Tesouro IPCA+");
    Console.WriteLine("[3] - CDB");
    Console.WriteLine("[4] - Poupança");
    opcao = int.Parse(Console.ReadLine());
    if (opcao == 0)
        break;
    Console.WriteLine("Informe o Investimento Inicial: ");
    decimal investimentoInicial = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Informe o Aporte Mensal: ");
    decimal aporteMensal = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("[A] - Meses");
    Console.WriteLine("[B] - Anos");
    string unidade = Console.ReadLine().ToUpper();
        do
        {
            Console.WriteLine("Opção inválida, tente novamente.");
            unidade = Console.ReadLine().ToUpper();
        } while (unidade != "A" && unidade != "B");
    Console.WriteLine("Informe o período: ");
    int periodo = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            TesouroSelic.CalculoSelic(investimentoInicial, aporteMensal, periodo, unidade);
            break;
        case 2:
            TesouroIPCA.CalculoIPCA(investimentoInicial, aporteMensal, periodo, unidade);
            break;
        case 3:
            CDB.CalculoCDB(investimentoInicial, aporteMensal, periodo, unidade);
            break;
        case 4:
            Poupanca.CalculoPoupanca(investimentoInicial, aporteMensal, periodo, unidade);
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

} while (opcao != 0);