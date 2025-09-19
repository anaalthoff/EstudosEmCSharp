namespace EstudosEmCSharp;

public class Calculadora
{
    public static void Somar()
    {
        Console.WriteLine("Escreva um número:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escreva outro número:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1 + num2);
    }


    public static void Subtrair()
    {
        Console.WriteLine("Escreva um número:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escreva outro número:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1 - num2);
    }

    public static void Multiplicar()
    {
        Console.WriteLine("Escreva um número:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escreva outro número:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1 * num2);
    }

    public static void Dividir()
    {
        Console.WriteLine("Escreva um número:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escreva outro número:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1 / num2);
    }
}