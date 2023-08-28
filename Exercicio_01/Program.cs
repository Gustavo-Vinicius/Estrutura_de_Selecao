Console.WriteLine("1 – Adição");
Console.WriteLine("2 – Subtração");
Console.WriteLine("3 – Multiplicação");
Console.WriteLine("4 – Divisão");

Console.WriteLine("Digite o número de uma ação :");
int condicao = Convert.ToInt32(Console.ReadLine());

switch (condicao)
{
    case 1 :
    Console.Write("\nDigite o primeiro valor: ");
    int valor1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nDigite o segundo valor: ");
    int valor2 = Convert.ToInt32(Console.ReadLine());

    var soma = valor1 + valor2; 

    Console.WriteLine("Valor da soma : " + soma);
    break;

    case 2 :
    Console.Write("\nDigite o primeiro valor: ");
    int valorum = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nDigite o segundo valor: ");
    int valordois = Convert.ToInt32(Console.ReadLine());

    var sub = valorum - valordois; 

    Console.WriteLine("Valor da subtracao : " + sub);
    break;

    case 3 :
    Console.Write("\nDigite o primeiro valor: ");
    int vlrum = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nDigite o segundo valor: ");
    int vlrdois = Convert.ToInt32(Console.ReadLine());

    var mult = vlrum - vlrdois; 

    Console.WriteLine("Valor da multplicacao : " + mult);

    break;

    case 4 :
    Console.Write("\nDigite o primeiro valor: ");
    int value1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nDigite o segundo valor: ");
    int value2 = Convert.ToInt32(Console.ReadLine());

    var div = value1 - value2; 

    Console.WriteLine("Valor da Divisão : " + div);
    break;

    default:

    break;
}