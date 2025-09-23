using Investimento_Financeiro.investimentos;
int opcao; //
double TPoupancaM;
if (TesouroSelic.taxaSelicAnual > 0.085)
{
    TPoupancaM = 0.005 + Poupanca.referencial;
}
else
{
    TPoupancaM = (TesouroSelic.taxaMensal * 0.7) + Poupanca.referencial;
}
double TPoupancaA = Math.Pow((1 + TPoupancaM), 12) - 1;
do
{
    Console.WriteLine($"[0] - Sair");
    Console.WriteLine($"[1] - Tesouro Selic: {TesouroSelic.taxaSelicAnual * 100:F2}% a.a.");
    Console.WriteLine($"[2] - Tesouro IPCA+: {((1 + TesouroIPCA.ipcaAnual) * (1 + TesouroIPCA.FixaAnual) - 1) * 100:F2}% a.a.");
    Console.WriteLine($"[3] - CDB: {CDB.cdi * 100:F2}% a.a.");
    Console.WriteLine($"[4] - Poupança: {TPoupancaA * 100:F2}% a.a. ");
    Console.WriteLine($"[5] - Comparar Montante Final de Investimentos");
    if (int.TryParse(Console.ReadLine(), out opcao))
    {
        switch (opcao)
        {
            case 1:
                bool entradaValida = false;
                decimal investimentoInicial = 0;
                Console.WriteLine("Informe o Investimento Inicial: ");
                while (entradaValida == false)
                {
                    if (decimal.TryParse(Console.ReadLine(), out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                decimal aporteMensal = 0;
                Console.WriteLine("Informe o Aporte Mensal: ");
                while (entradaValida == false)
                {
                    if (decimal.TryParse(Console.ReadLine(), out aporteMensal) && aporteMensal >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                Console.WriteLine("[A] - Meses");
                Console.WriteLine("[B] - Anos");
                string unidade = Console.ReadLine().ToUpper();
                while (unidade != "A" && unidade != "B")
                {

                    Console.WriteLine("Opção inválida, tente novamente.");
                    unidade = Console.ReadLine().ToUpper();

                }

                int periodo = 0;
                entradaValida = false;
                Console.WriteLine("Informe o período de investimento: ");
                while (entradaValida == false)
                {
                    if (int.TryParse(Console.ReadLine(), out periodo) && periodo > 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                TesouroSelic.CalculoSelic(investimentoInicial, aporteMensal, periodo, unidade);
                break;

            case 2:
                entradaValida = false;
                investimentoInicial = 0;
                Console.WriteLine("Informe o Investimento Inicial: ");
                while (entradaValida == false)       
                {
                    if (decimal.TryParse(Console.ReadLine(), out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                aporteMensal = 0;
                Console.WriteLine("Informe o Aporte Mensal: ");
                while (entradaValida == false)
                {
                    if (decimal.TryParse(Console.ReadLine(), out aporteMensal) && aporteMensal >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                Console.WriteLine("[A] - Meses");
                Console.WriteLine("[B] - Anos");
                unidade = Console.ReadLine().ToUpper();
                while (unidade != "A" && unidade != "B")
                {

                    Console.WriteLine("Opção inválida, tente novamente.");
                    unidade = Console.ReadLine().ToUpper();

                }

                periodo = 0;
                entradaValida = false;
                Console.WriteLine("Informe o período de investimento: ");
                while (entradaValida == false)
                {
                    if (int.TryParse(Console.ReadLine(), out periodo) && periodo > 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                TesouroIPCA.CalculoIPCA(investimentoInicial, aporteMensal, periodo, unidade);
                break;

            case 3:
                entradaValida = false;
                investimentoInicial = 0;
                Console.WriteLine("Informe o Investimento Inicial: ");
                while (entradaValida == false)
                {
                    if (decimal.TryParse(Console.ReadLine(), out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                aporteMensal = 0;
                Console.WriteLine("Informe o Aporte Mensal: ");
                while (entradaValida == false)
                {
                    if (decimal.TryParse(Console.ReadLine(), out aporteMensal) && aporteMensal >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                Console.WriteLine("[A] - Meses");
                Console.WriteLine("[B] - Anos");
                unidade = Console.ReadLine().ToUpper();
                while (unidade != "A" && unidade != "B")
                {

                    Console.WriteLine("Opção inválida, tente novamente.");
                    unidade = Console.ReadLine().ToUpper();

                }

                periodo = 0;
                entradaValida = false;
                Console.WriteLine("Informe o período de investimento: ");
                while (entradaValida == false)
                {
                    if (int.TryParse(Console.ReadLine(), out periodo) && periodo > 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                CDB.CalculoCDB(investimentoInicial, aporteMensal, periodo, unidade);
                break;

            case 4:
                entradaValida = false;
                investimentoInicial = 0;
                Console.WriteLine("Informe o Investimento Inicial: ");
                while (entradaValida == false)
                {
                    if (decimal.TryParse(Console.ReadLine(), out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                aporteMensal = 0;
                Console.WriteLine("Informe o Aporte Mensal: ");
                while (entradaValida == false)
                {
                    if (decimal.TryParse(Console.ReadLine(), out aporteMensal) && aporteMensal >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                Console.WriteLine("[A] - Meses");
                Console.WriteLine("[B] - Anos");
                unidade = Console.ReadLine().ToUpper();
                while (unidade != "A" && unidade != "B")
                {

                    Console.WriteLine("Opção inválida, tente novamente.");
                    unidade = Console.ReadLine().ToUpper();

                }

                periodo = 0;
                entradaValida = false;
                Console.WriteLine("Informe o período de investimento: ");
                while (entradaValida == false)
                {
                    if (int.TryParse(Console.ReadLine(), out periodo) && periodo > 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                Poupanca.CalculoPoupanca(investimentoInicial, aporteMensal, periodo, unidade);
                break;

            case 5:
                entradaValida = false;
                investimentoInicial = 0;
                Console.WriteLine("Informe o Investimento Inicial: ");
                while (entradaValida == false)
                {
                    if (decimal.TryParse(Console.ReadLine(), out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                aporteMensal = 0;
                Console.WriteLine("Informe o Aporte Mensal: ");
                while (entradaValida == false)
                {
                    if (decimal.TryParse(Console.ReadLine(), out aporteMensal) && aporteMensal >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                Console.WriteLine("[A] - Meses");
                Console.WriteLine("[B] - Anos");
                unidade = Console.ReadLine().ToUpper();
                while (unidade != "A" && unidade != "B")
                {

                    Console.WriteLine("Opção inválida, tente novamente.");
                    unidade = Console.ReadLine().ToUpper();

                }

                periodo = 0;
                entradaValida = false;
                Console.WriteLine("Informe o período de investimento: ");
                while (entradaValida == false)
                {
                    if (int.TryParse(Console.ReadLine(), out periodo) && periodo > 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                Comparar.Comparacao(investimentoInicial, aporteMensal, periodo, unidade);
                break;

            case 0:
                break;

            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                break;
        }

    }
    else
    {
        Console.WriteLine("Opção inválida, tente novamente.");
        opcao = -1;
    }
} while (opcao != 0);