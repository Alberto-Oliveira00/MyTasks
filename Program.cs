using MyTasks;

class Program
{
    private static GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
    private static int proximoId = 1;
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Bem vindo ao MyTasks");
        Console.WriteLine("--------------------\n");
        Console.WriteLine("Escolha uma opção para continuar:\n");
        Console.WriteLine("1 - Adicionar nova tarefa");
        Console.WriteLine("2 - Listar todas tarefas");
        Console.WriteLine("3 - Listar tarefas pendentes");
        Console.WriteLine("4 - Concluir uma tarefa");
        Console.WriteLine("5 - Remover uma tarefa");
        Console.WriteLine("6 - Sair");

        Console.WriteLine("\n--------------------");

        if (!short.TryParse(Console.ReadLine(), out short res))
        {
            Console.WriteLine("Opção inválida!");
            Thread.Sleep(1500);
            return;
        }

        switch (res)
        {
            case 1:
                AdicionarTarefa();
                break;
            case 2:
                ListarTarefas();
                break;
            case 3:
                ListarTarefasPendentes();
                break;
            case 4:
                ConcluirTarefa();
                break;
            case 5:
                RemoverTarefa();
                break;
            case 6:
                Environment.Exit(0);
                break;

            default: Menu(); break;
        }
    }
    static void AdicionarTarefa()
    {
        Console.Clear();
        Console.WriteLine("--- Adicionar Nova Tarefa ---");

        int idTarefa = proximoId++;

        Console.Write("Informe o título da tarefa: ");
        string titulo = Console.ReadLine()!;

        Console.Write("Informe a descrição da tarefa: ");
        string descricao = Console.ReadLine()!;

        Tarefa novaTarefa = new Tarefa(idTarefa, titulo, descricao, false);

        gerenciador.AdicionarTarefa(novaTarefa);

        Console.WriteLine("\nTarefa adicionada com sucesso!");

        Thread.Sleep(2000);

        Menu();
    }
    static void ListarTarefas()
    {
        Console.Clear();
        gerenciador.ListarTarefas();
        Thread.Sleep(2000);
        Console.WriteLine("Aperte qualquer tecla para retornar ao menu...");
        Console.ReadKey();
        Menu();
    }
    static void ListarTarefasPendentes()
    {
        Console.Clear();
        Console.WriteLine("-----------------");
        Console.WriteLine("Tarefas pendentes");
        Console.WriteLine("-----------------");
        gerenciador.ListarTarefasPendentes();
        Thread.Sleep(2000);
        Console.WriteLine("Aperte qualquer tecla para retornar ao menu...");
        Console.ReadKey();
        Menu();
    }
    static void ConcluirTarefa()
    {
        Console.Clear();
        Console.WriteLine("---------------");
        Console.WriteLine("Concluir tarefa");
        Console.WriteLine("---------------");
        Console.WriteLine("\nPara concluir sua tarefa informe o Id dela");
        if (int.TryParse(Console.ReadLine(), out int idTarefa))
        {
            gerenciador.ConcluirTarefa(idTarefa);
        }
        else
        {
            Console.WriteLine("ID inválido. Por favor, digite um número.");
        }

        Thread.Sleep(2000);
        Menu();
    }
    static void RemoverTarefa()
    {
        Console.WriteLine("--------------");
        Console.WriteLine("Remover tarefa");
        Console.WriteLine("--------------");

        Console.Write("Para remover uma tarefa informe o Id dela:");
        if (int.TryParse(Console.ReadLine(), out int idTarefa))
        {
            gerenciador.RemoverTarefa(idTarefa);
        }
        else
        {
            Console.WriteLine("ID inválido. Por favor, digite um número.");
        }
        Thread.Sleep(1000);
        Console.WriteLine("Digite alguma tecla para retornar ao menu...");
        Console.ReadKey();
        Menu();
    }
}