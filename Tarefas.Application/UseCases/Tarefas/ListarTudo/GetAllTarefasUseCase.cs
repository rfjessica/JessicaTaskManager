using Tarefas.Communication.Enums;
using Tarefas.Communication.Responses;

namespace Tarefas.Application.UseCases.Tarefas.ListarTudo;
public class GetAllTarefasUseCase
{
    public ResponseAllTarefaJson Execute()
    {
        return new ResponseAllTarefaJson
        {
            Tarefas = new List<ResponseShortTarefaJson>
            {
                new ResponseShortTarefaJson {
                    Id = 1,
                    Nome = "Lavar roupa",
                    Prioridade = PrioridadeType.Média
                },
                new ResponseShortTarefaJson {
                    Id = 2,
                    Nome = "Lavar louça",
                    Prioridade = PrioridadeType.Alta
                },
                new ResponseShortTarefaJson {
                    Id = 3,
                    Nome = "Limpar o quarto",
                    Prioridade = PrioridadeType.Baixa   
                }
            }
        }; 
    }
}
