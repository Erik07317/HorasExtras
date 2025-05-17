decimal salarioHora;
int horasTrabalhadas, horasextras;

Console.WriteLine("Olá, seja bem-vindo ao programa de cálculo de salário!");
Console.ReadKey();

Console.WriteLine("---------Horas Extras---------");

Console.Write("Digite o valor do salário por hora R$: ");
salarioHora = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o número de horas trabalhadas no mês: ");
horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o número de horas extras trabalhadas no mês: ");
horasextras = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------");
Console.WriteLine("---------Resultado---------");
decimal total = salarioHora * horasTrabalhadas + (salarioHora * 0.4m) * horasextras;
Console.WriteLine($"O salário total é: R$ {total}");
Console.WriteLine("------------------------------");