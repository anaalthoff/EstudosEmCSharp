namespace EstudosEmCSharp;

public class EstruturaCondicional
{
    public static void Ifs()
    {
        // Verifica se é número par ou ímpar
        Console.WriteLine("Digite um número: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = number % 2;
        if (result == 0)
        {
            Console.WriteLine("Número par");
        }
        else
        {
            Console.WriteLine("Número ímpar");
        }
    }
}
