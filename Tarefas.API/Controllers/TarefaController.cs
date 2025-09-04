using Microsoft.AspNetCore.Mvc;
using Tarefas.Application.UseCases.Tarefas.Cadastrar;
using Tarefas.Application.UseCases.Tarefas.Deletar;
using Tarefas.Application.UseCases.Tarefas.Editar;
using Tarefas.Application.UseCases.Tarefas.GetById;
using Tarefas.Application.UseCases.Tarefas.ListarTudo;
using Tarefas.Communication.Requests;
using Tarefas.Communication.Responses;

namespace Tarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]

public class TarefaController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredTarefaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Cadastro([FromBody] RequestTarefaJson requisicao){
        var casoDeUso = new CadastroTarefaUseCase();
        var resposta = casoDeUso.Execute(requisicao);
        return Created(string.Empty, resposta);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Edicao([FromRoute] int id, [FromBody] RequestTarefaJson requisicao){
        var casoDeUso = new EdicaoTarefaUseCase();
        casoDeUso.Execute(id, requisicao);
        return NoContent();
    }


    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ListarTodos()
    {
        var casoDeUso = new GetAllTarefasUseCase();
        var resposta = casoDeUso.Execute();

        if (resposta.Tarefas.Any()) //se a lista Tarefas tem algum item
        {
            return Ok(resposta);
        }

        return NoContent();
    }


    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(RequestTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult ObterDados(int id)
    {
        var casoDeUso = new GetTarefaByIdUseCase();
        var resposta = casoDeUso.Execute(id);

        return Ok(resposta);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult Exclusao(int id){
        var casoDeUso = new DeleteTarefaUseCase();
        casoDeUso.Execute(id);
        return NoContent();
    }
}
