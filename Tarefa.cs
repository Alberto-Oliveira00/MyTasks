namespace MyTasks;

internal class Tarefa
{
    public Tarefa(int id, string titulo, string descricao, bool concluida)
    {
        Id = id;
        Titulo = titulo;
        Descricao = descricao;
        Concluida = concluida;
        CriadaEm = DateTime.Now;
    }
    public int Id { get; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public bool Concluida { get; set; }
    public DateTime CriadaEm { get; }
    public DateTime ConcluidaEm { get; set; }

    public void Concluir()
    {
        Concluida = true;
        ConcluidaEm = DateTime.Now;
    }
}