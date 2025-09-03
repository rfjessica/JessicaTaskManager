namespace Tarefas.Communication.Requests;
public class RequestTarefaJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
}
