using System.Globalization;
using Tarefas.Communication.Requests;
using Tarefas.Communication.Responses;

namespace Tarefas.Application.UseCases.Tarefas.Cadastrar;
public class CadastroTarefaUseCase
{
    public ResponseRegisteredTarefaJson Cadastra(RequestCreateTarefaJson requisicao)
    {
        return new ResponseRegisteredTarefaJson
        {
            Nome = requisicao.Nome,
            Descricao = requisicao.Descricao,
            Status = requisicao.Status,
            Prioridade = requisicao.Prioridade,
            DataLimite = DateTime.Now.AddDays(15)
        };
    }
}
