namespace EstudosEmCSharp;

public class Switch
{
    public static void EstacoesDoAno()
    {
        Console.WriteLine("Digite um número de 1 a 4: ");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Verão");
                break;
            case 2:
                Console.WriteLine("Outono");
                break;
            case 3:
                Console.WriteLine("Inverno");
                break;
            case 4:
                Console.WriteLine("Primavera");
                break;
            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }
}
