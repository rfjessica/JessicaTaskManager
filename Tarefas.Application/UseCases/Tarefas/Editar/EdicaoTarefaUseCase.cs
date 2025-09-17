using Tarefas.Communication.Requests;
using Tarefas.Communication.Responses;

namespace Tarefas.Application.UseCases.Tarefas.Editar;
public class EdicaoTarefaUseCase
{
    public ResponseRegisteredTarefaJson Atualiza(int id, RequestUpdateTarefaJson requisicao)
    {
        return new ResponseRegisteredTarefaJson
        {
            Id = id,
            Nome = requisicao.Nome,
            Descricao = requisicao.Descricao,
            Status = requisicao.Status,
            Prioridade = requisicao.Prioridade,
            DataLimite = DateTime.Now.AddDays(15)
        };
    }
}