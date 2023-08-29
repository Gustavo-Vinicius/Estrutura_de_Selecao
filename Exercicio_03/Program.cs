Console.Write("Digite a altura (em metros): ");
double altura = double.Parse(Console.ReadLine());

Console.Write("Digite o sexo (M para masculino, F para feminino): ");
char sexo = char.Parse(Console.ReadLine().ToUpper());

double pesoIdeal = 0;

if (sexo == 'M')
{
    pesoIdeal = (72.7 * altura) - 58;
}
else if (sexo == 'F')
{
    pesoIdeal = (62.1 * altura) - 44.7;
}
else
{
    Console.WriteLine("Sexo inválido.");
    return;
}

Console.WriteLine($"O peso ideal é: {pesoIdeal:F2} kg");
