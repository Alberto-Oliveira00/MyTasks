namespace MyTasks;

internal class GerenciadorDeTarefas
{
    private List<Tarefa> tarefas = new List<Tarefa>();

    public void AdicionarTarefa(Tarefa tarefa)
    {
        tarefas.Add(tarefa);
    }
    public void RemoverTarefa(int id)
    {
        Tarefa? tarefaParaRemover = null;
        foreach (var t in tarefas)
        {
            if (t.Id == id)
            {
                tarefaParaRemover = t;
                break;
            }
        }

        if (tarefaParaRemover != null)
        {
            tarefas.Remove(tarefaParaRemover);
            Console.WriteLine($"Tarefa com ID {id} removida com sucesso!");
        }
        else
        {
            Console.WriteLine($"Tarefa com ID {id} não encontrada.");
        }
    }

    public void ListarTarefas()
    {
        Console.WriteLine("Lista de tarefas: \n");
        foreach (var t in tarefas)
        {
            ExibirTarefa(t);
            // Console.WriteLine($"Tarefa: {t.Titulo} - id: {t.Id} - Descrição: {t.Descricao} - Concluida: {t.Concluida}\n");
        }
    }

    public void ListarTarefasPendentes()
    {
        var pendentes = tarefas.Where(t => !t.Concluida).ToList();

        if (pendentes.Count == 0)
        {
            Console.WriteLine("Não há tarefas pendentes.");
            return;
        }
        foreach (var t in pendentes)
        {
            ExibirTarefa(t);
            // Console.WriteLine($"Tarefa: {t.Titulo} - id: {t.Id} - Descrição: {t.Descricao}");
        }
    }

    public void ConcluirTarefa(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);

        if (tarefa != null)
        {
            tarefa.Concluir();
            Console.WriteLine($"Tarefa com o id {id} concluída com sucesso!");
        }
        else
        {
            Console.WriteLine($"Tarefa com o id {id} não encontrada.");
        }
    }

    static void ExibirTarefa(Tarefa t)
    {
        Console.WriteLine($"ID: {t.Id} | Título: {t.Titulo} | Descrição: {t.Descricao} | Criada em: {t.CriadaEm:dd/MM/yyyy HH:mm}| Concluída: {(t.Concluida ? $"Sim, tarefa concluida em: {t.ConcluidaEm:dd/MM/yyyy HH:mm}" : "Não")}");
    }
}

