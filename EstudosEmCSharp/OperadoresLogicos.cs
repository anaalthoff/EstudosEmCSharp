namespace EstudosEmCSharp;

public class OperadoresLogicos
{
    public static void OperadorLogico()
    {
        bool isLogged = true;
        bool isAdmin = false;

        Console.WriteLine("Informações do usuário: ");
        Console.WriteLine($"Usuário logado: {isLogged}");
        Console.WriteLine($"Usuário é administrador: {isAdmin}");

        // Operador || (OU)
        if (isLogged == false || isAdmin == true)
        {
            Console.WriteLine("Acesso ao sistema permitido.");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema não permitido.");
        }

        // Operador && (E)
        if (isLogged && isAdmin)
        {
            Console.WriteLine("Usuário logado e administrador");
        }
        // Operador ! (NÃO)
        else if (isLogged && !isAdmin)
        {
            Console.WriteLine("Usuário logado e não é administrador");
        }

    }
}