namespace EstudosEmCSharp;

public class OperadoresDeAtribuicao
{
    public static void OperadorDeAtribuicao()
    {
        int number = 10;
        Console.WriteLine(number);
        // Atribuição Simples
        number = 20;
        Console.WriteLine(number);

        // Atribuição Composta (incremento ++)
        number++; // x = x + 1
        Console.WriteLine(number);

        // Atribuição Composta (incremento +=)
        number += 5; // x = x + 5
        Console.WriteLine(number);

        // Atribuição Composta (decrimento  -=)
        number += 3; // x = x - 3
        Console.WriteLine(number);

        // Atribuição Composta (multiplicação *=)
        number *= 2; // x = x * 2
        Console.WriteLine(number);

        // Atribuição Composta (divisão /=)
        number /= 2; // x = x / 2
        Console.WriteLine(number);

        // Atribuição Composta (resto da divisão %=)
        number %= 2; // x = x % 2
        Console.WriteLine(number);
    }
}