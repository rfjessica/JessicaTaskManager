namespace Tarefas.Communication.Responses;
public class ResponseRegisteredTarefaJson //classe pra edição da tarefa    
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
}
