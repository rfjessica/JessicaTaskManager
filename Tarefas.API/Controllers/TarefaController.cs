using Microsoft.AspNetCore.Mvc;
using Tarefas.Application.UseCases.Tarefas.Cadastrar;
using Tarefas.Application.UseCases.Tarefas.Deletar;
using Tarefas.Application.UseCases.Tarefas.Editar;
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
    /* public IActionResult ListarDados(){}
    public IActionResult ObterDados(int id){}*/
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
