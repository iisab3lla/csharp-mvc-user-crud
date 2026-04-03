using System.Collections.Generic;
using System.Linq;
using CRUDMVC.Models;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace CRUDMVC.Controllers;

public class UsuarioController
{
    public List<Usuario> usuarios = new List<Usuario>();

    public void AdicionarUsuario(string nome)
    {
        var usuario = new Usuario { Id = usuarios.Count + 1, Nome = nome };
        usuarios.Add(usuario);
    }

    public List<Usuario> ListarUsuarios()
    {
        return usuarios;
    }

    public bool AtualizarUsuario(int id, string novoNome)
    {
        var usuario = usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario != null)
        {
            usuario.Nome = novoNome;
            return true;
        }
        return false;
    }

    public bool DeletarUsuario(int id)
    {
        var usuario = usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario != null)
        {
            usuarios.Remove(usuario);
            return true;
        }
        return false;
    }
}