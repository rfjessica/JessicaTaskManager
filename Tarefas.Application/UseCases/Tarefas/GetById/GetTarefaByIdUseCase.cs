using Tarefas.Communication.Enums;
using Tarefas.Communication.Responses;

namespace Tarefas.Application.UseCases.Tarefas.GetById;
public class GetTarefaByIdUseCase
{
    public ResponseTarefaJson Execute(int id)
    {
        return new ResponseTarefaJson
        {
            Id = id,
            Nome = "Tarefa Exemplo",
            Descricao = "Descrição da tarefa exemplo",
            Prioridade = PrioridadeType.Baixa,
            DataLimite = new DateTime(year: 2026, month: 01, day:01),
            Status = StatusType.Aguardando
        };
    }
}
