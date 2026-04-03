using CRUDMVC.Controllers;
using CRUDMVC.View;

var UsuarioController = new UsuarioController();
var usuarioView = new UsuarioView();
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Adicionar Usuário");
    Console.WriteLine("2. Listar Usuário");
    Console.WriteLine("3. Atualizar Usuário");
    Console.WriteLine("4. Deletar Usuário");
    Console.WriteLine("5. Sair");


    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        Console.WriteLine("Digite o nome do usuário");
        var nome = Console.ReadLine();
        UsuarioController.AdicionarUsuario(nome);
        usuarioView.MostrarMensagem("Usuário adicionado com sucesso!");
        break;
     case "2":
        var usuarios = UsuarioController.ListarUsuarios();
        usuarioView.MostrarUsuarios(usuarios);
        break;
    case "3":
        Console.WriteLine("Digite o ID do usuário a ser atualizado:");
        var idAtualizar = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o novo nome do usuário:");
        var novoNome = Console.ReadLine();
        if (UsuarioController.AtualizarUsuario(idAtualizar, novoNome))
            usuarioView.MostrarMensagem("Usuário atualizado com sucesso!");
        else
            usuarioView.MostrarMensagem("Usuário não encontrado");
        break;
    case "4": 
        Console.WriteLine("Digite o ID do usuário a ser deletado: ");
        var idDeletar = int.Parse(Console.ReadLine());
        if(UsuarioController.DeletarUsuario(idDeletar))
            usuarioView.MostrarMensagem("Usuário deletado com sucesso!");
        else    
            usuarioView.MostrarMensagem("Usuário não encontrado.");
        break;
    case "5":
        continuar = false;
        break;
    default:
        usuarioView.MostrarMensagem("Opção inválida. Tente novamente.");
        break;
    }
}