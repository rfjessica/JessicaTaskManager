using Tarefas.Communication.Enums;

namespace Tarefas.Communication.Requests;
public class RequestUpdateTarefaJson
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public StatusType Status { get; set; }
    public PrioridadeType Prioridade { get; set; }
}
