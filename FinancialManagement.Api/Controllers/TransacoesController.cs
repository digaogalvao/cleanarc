using FinancialManagement.Application.UseCases.CreateTransacao;
using FinancialManagement.Application.UseCases.DeleteTransacao;
using FinancialManagement.Application.UseCases.GetAllTransacao;
using FinancialManagement.Application.UseCases.UpdateTransacao;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FinancialManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransacoesController : ControllerBase
{
    IMediator _mediator;
    public TransacoesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /*[HttpPost("adicionarTransacao")]
    public IActionResult AdicionarTransacao([FromBody] Transacao transacao)
    {
        _transacaoService.AdicionarTransacao(transacao);
        return Ok();
    }

    [HttpGet("gerarRelatorioDiario")]
    public IActionResult GerarRelatorioDiario([FromQuery] DateTime data)
    {
        var relatorioDiario = _transacaoService.GerarRelatorioDiario(data);
        return Ok(relatorioDiario);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Transacao>>> Index()
    {
        TransacaoViewModel model = await _transacaoService.GetTransacoes();
        return Ok(model);
    }

    [HttpGet("{id:int}", Name = "GetTransacao")]
    public async Task<ActionResult<Transacao>> Details(int id)
    {
        TransacaoViewModel model = await _transacaoService.GetTransacao(id);

        if (model == null)
            return NotFound($"Transação com id= {id} não encontrada");

        return Ok(model);
    }*/


    [HttpGet]
    public async Task<ActionResult<List<GetAllTransacaoResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllTransacaoRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTransacaoRequest request)
    {
        var userId = await _mediator.Send(request);
        return Ok(userId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateTransacaoResponse>>
        Update(Guid id, UpdateTransacaoRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
            return BadRequest();

        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid? id,
                                           CancellationToken cancellationToken)
    {
        if (id is null)
            return BadRequest();

        var deleteUserRequest = new DeleteTransacaoRequest(id.Value);

        var response = await _mediator.Send(deleteUserRequest, cancellationToken);
        return Ok(response);
    }
}
