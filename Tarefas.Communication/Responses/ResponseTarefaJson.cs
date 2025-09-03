using Tarefas.Communication.Enums;

namespace Tarefas.Communication.Responses;
public class ResponseTarefaJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public PrioridadeType Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public StatusType Status { get; set; }
}
