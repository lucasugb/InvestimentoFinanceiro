using Investimento_Financeiro.TesouroSelic;

Console.WriteLine("Informe o capital inicial: ");
double capitalInicial = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a taxa anual: ");
double taxaAnual = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o período em anos: ");
int periodo = Convert.ToInt32(Console.ReadLine());

decimal montante = TesouroSelic.Calcular(capitalInicial, taxaAnual, periodo);
Console.WriteLine(montante);