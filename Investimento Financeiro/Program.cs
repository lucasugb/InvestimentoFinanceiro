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

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe o Investimento Inicial: ");
            decimal investimentoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o Aporte Mensal: ");
            decimal aporteMensal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("[A] - Meses");
            Console.WriteLine("[B] - Anos");
            string unidade = Console.ReadLine().ToUpper();
            if (unidade != "A" && unidade != "B")
            {
                do
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    unidade = Console.ReadLine().ToUpper();
                } while (unidade != "A" && unidade != "B");
            }
            Console.WriteLine("Informe o período: ");
            int periodo = Convert.ToInt32(Console.ReadLine());
            TesouroSelic.CalculoSelic(investimentoInicial, aporteMensal, periodo, unidade);
            break;
        case 2:
            Console.WriteLine("Informe o Investimento Inicial: ");
            investimentoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o Aporte Mensal: ");
            aporteMensal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("[A] - Meses");
            Console.WriteLine("[B] - Anos");
            unidade = Console.ReadLine().ToUpper();
            if (unidade != "A" && unidade != "B")
            {
                do
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    unidade = Console.ReadLine().ToUpper();
                } while (unidade != "A" && unidade != "B");
            }
            Console.WriteLine("Informe o período: ");
            periodo = Convert.ToInt32(Console.ReadLine());
            TesouroIPCA.CalculoIPCA(investimentoInicial, aporteMensal, periodo, unidade);
            break;
        case 3:
            Console.WriteLine("Informe o Investimento Inicial: ");
            investimentoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o Aporte Mensal: ");
            aporteMensal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("[A] - Meses");
            Console.WriteLine("[B] - Anos");
            unidade = Console.ReadLine().ToUpper();
            if (unidade != "A" && unidade != "B")
            {
                do
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    unidade = Console.ReadLine().ToUpper();
                } while (unidade != "A" && unidade != "B");
            }
            Console.WriteLine("Informe o período: ");
            periodo = Convert.ToInt32(Console.ReadLine());
            CDB.CalculoCDB(investimentoInicial, aporteMensal, periodo, unidade);
            break;
        case 4:
            Console.WriteLine("Informe o Investimento Inicial: ");
            investimentoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o Aporte Mensal: ");
            aporteMensal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("[A] - Meses");
            Console.WriteLine("[B] - Anos");
            unidade = Console.ReadLine().ToUpper();
            if (unidade != "A" && unidade != "B")
            {
                do
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    unidade = Console.ReadLine().ToUpper();
                } while (unidade != "A" && unidade != "B");
            }
            Console.WriteLine("Informe o período: ");
            periodo = Convert.ToInt32(Console.ReadLine());
            Poupanca.CalculoPoupanca(investimentoInicial, aporteMensal, periodo, unidade);
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

} while (opcao != 0);