using Tarefas.Communication.Enums;

namespace Tarefas.Communication.Responses;
public class ResponseShortTarefaJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public PrioridadeType Prioridade { get; set; }
}
