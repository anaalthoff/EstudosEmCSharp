namespace EstudosEmCSharp;

public class Calculadora
{
    public static void Calcular()
    {
        Console.WriteLine("Escreva um número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escreva outro número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("Digite o numero da Operação: ");

        int opcao = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        if (opcao == 1)
        {
            resultado = Somar(num1, num2);
        }
        else if (opcao == 2)
        {
            resultado = Subtrair(num1, num2);
        }
        else if (opcao == 3)
        {
            resultado = Multiplicar(num1, num2);
        }
        else if (opcao == 4)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            else
            {
                resultado = Dividir(num1, num2);
            }
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
        Console.WriteLine($"O resultado é: {resultado}");
    }
    public static double Somar(double num1, double num2)
    {
        // Console.WriteLine("Escreva um número:");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Escreva outro número:");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(num1 + num2);
        return num1 + num2;
    }


    public static double Subtrair(double num1, double num2)
    {
        // Console.WriteLine("Escreva um número:");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Escreva outro número:");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(num1 - num2);
        return num1 - num2;
    }

    public static double Multiplicar(double num1, double num2)
    {
        // Console.WriteLine("Escreva um número:");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Escreva outro número:");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(num1 * num2);
        return num1 * num2;
    }

    public static double Dividir(double num1, double num2)
    {
        // Console.WriteLine("Escreva um número:");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Escreva outro número:");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(num1 / num2);
        return num1 / num2;
    }
}