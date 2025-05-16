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
Console.WriteLine($"Salário bruto: R$ {salarioHora * horasTrabalhadas}");
Console.WriteLine($"Salário hora extra: R$ {salarioHora * 1.5m * horasextras}");
Console.WriteLine($"Salário total: R$ {(salarioHora * horasTrabalhadas) + (salarioHora * 1.5m * horasextras)}");