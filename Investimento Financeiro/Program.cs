using Investimento_Financeiro.investimentos;
int opcao;
double TPoupancaM;
if (TesouroSelic.taxaSelicAnual > 0.085)
{
    TPoupancaM = 0.005 + Poupanca.referencial;
}
else
{
    TPoupancaM = Poupanca.referencial + (Math.Pow(TesouroSelic.taxaSelicAnual, 1.0 / 12.0) * 0.7);
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
                decimal investimentoInicial = 0;
                decimal aporteMensal = 0;
                bool entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Investimento Inicial: ");
                    string valorInvIni = Console.ReadLine();

                    if (decimal.TryParse(valorInvIni, out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Aporte Mensal: ");
                    string valorAM = Console.ReadLine();

                    if (decimal.TryParse(valorAM, out aporteMensal) && aporteMensal >= 0)
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
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o período de investimento: ");
                    string valorP = Console.ReadLine();

                    if (int.TryParse(valorP, out periodo) && periodo > 0)
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
                investimentoInicial = 0;
                aporteMensal = 0;
                entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Investimento Inicial: ");
                    string valorII = Console.ReadLine();

                    if (decimal.TryParse(valorII, out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Aporte Mensal: ");
                    string valorAM = Console.ReadLine();

                    if (decimal.TryParse(valorAM, out aporteMensal) && aporteMensal >= 0)
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
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o período de investimento: ");
                    string valorP = Console.ReadLine();

                    if (int.TryParse(valorP, out periodo) && periodo > 0)
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
                investimentoInicial = 0;
                aporteMensal = 0;
                entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Investimento Inicial: ");
                    string valorII = Console.ReadLine();

                    if (decimal.TryParse(valorII, out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Aporte Mensal: ");
                    string valorAM = Console.ReadLine();

                    if (decimal.TryParse(valorAM, out aporteMensal) && aporteMensal >= 0)
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
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o período de investimento: ");
                    string valorP = Console.ReadLine();

                    if (int.TryParse(valorP, out periodo) && periodo > 0)
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
                investimentoInicial = 0;
                aporteMensal = 0;
                entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Investimento Inicial: ");
                    string valorII = Console.ReadLine();

                    if (decimal.TryParse(valorII, out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Aporte Mensal: ");
                    string valorAM = Console.ReadLine();

                    if (decimal.TryParse(valorAM, out aporteMensal) && aporteMensal >= 0)
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
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o período de investimento: ");
                    string valorP = Console.ReadLine();

                    if (int.TryParse(valorP, out periodo) && periodo > 0)
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
                investimentoInicial = 0;
                aporteMensal = 0;
                entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Investimento Inicial: ");
                    string valorII = Console.ReadLine();

                    if (decimal.TryParse(valorII, out investimentoInicial) && investimentoInicial >= 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                entradaValida = false;
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o Aporte Mensal: ");
                    string valorAM = Console.ReadLine();

                    if (decimal.TryParse(valorAM, out aporteMensal) && aporteMensal >= 0)
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
                while (entradaValida == false)
                {
                    Console.WriteLine("Informe o período de investimento: ");
                    string valorP = Console.ReadLine();

                    if (int.TryParse(valorP, out periodo) && periodo > 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
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