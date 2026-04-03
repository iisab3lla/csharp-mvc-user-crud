using CRUDMVC.Models;

namespace CRUDMVC.View;

public class UsuarioView
{
    public void MostrarUsuarios(List<Usuario> usuarios)
    {
        Console.WriteLine("Lista de Usuários:");

        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"ID: {usuario.Id}, Nome: {usuario.Nome}");
        }

        Console.WriteLine("---------------------------------\n");
    }
    public void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
}