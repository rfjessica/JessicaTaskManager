using Tarefas.Communication.Requests;
using Tarefas.Communication.Responses;

namespace Tarefas.Application.UseCases.Tarefas.Cadastrar;
public class CadastroTarefaUseCase
{
    public ResponseRegisteredTarefaJson Execute(RequestTarefaJson requisicao)
    {
        return new ResponseRegisteredTarefaJson
        {
            Id = 1,
            Nome = requisicao.Nome,
            Descricao = requisicao.Descricao
        };
    }
}
