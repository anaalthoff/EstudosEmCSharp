namespace EstudosEmCSharp;

public class InputEOutput
{
    public static void InputOutput()
    {
        Console.WriteLine("Escreva seu nome:");
        // Console.Readline lê apenas strings
        string name = Console.ReadLine();

        Console.WriteLine("Escreva sua idade:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Nome do usuário é {name} e tem {age} anos.");
    }
}
