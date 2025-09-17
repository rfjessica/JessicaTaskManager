using Tarefas.Communication.Enums;

namespace Tarefas.Communication.Requests;
public class RequestCreateTarefaJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataLimite;
    public StatusType Status { get; set; }
    public PrioridadeType Prioridade { get; set; }
}
