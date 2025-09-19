namespace EstudosEmCSharp;

public class Constantes
{
    public static void Constante()
    {
        const string name = "Ana";
        const int age = 20;
        const char character = 'e';
        // É um tipo dinâmico, muda o tipo , pode atribuir outro valores, será o últipo tipo
        dynamic teste = 20;
        teste = "teste";
        Console.WriteLine($"Olá, meu nome é {name} {character} tenho {age} anos. Escrito com constantes.");
    }
}