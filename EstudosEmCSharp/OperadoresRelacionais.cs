namespace EstudosEmCSharp;

public class OperadoresRelacionais
{
    public static void OperadorRelacional()
    {
        Console.WriteLine("Digite o primeiro número: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Operador de Igualdade
        if (number == number2)
        {
            Console.WriteLine("Os números são iguais");
        }
        else
        {
            Console.WriteLine("Os números são diferentes");
        }

        if (number != number2)
        {
            Console.WriteLine("Os números são diferentes");
        }
        else
        {
            Console.WriteLine("Os números são iguais");
        }
        if (number > number2)
        {
            Console.WriteLine("O primeiro número é maior que o segundo");
        }
        else
        {
            Console.WriteLine("O primeiro número é menor que o segundo");
        }
    }
}