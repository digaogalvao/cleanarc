using FinancialManagement.Application.UseCases.TransacaoCreate;
using FinancialManagement.Application.UseCases.TransacaoDelete;
using FinancialManagement.Application.UseCases.TransacaoGetAll;
using FinancialManagement.Application.UseCases.TransacaoGetById;
using FinancialManagement.Application.UseCases.TransacaoUpdate;
using FinancialManagement.Domain.Entities;
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
    public async Task<ActionResult<List<TransacaoGetAllResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new TransacaoGetAllRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TransacaoGetByIdResponse>> 
        GetById(Guid id, CancellationToken cancellationToken)
    {
        var request = new TransacaoGetByIdRequest(id);

        var response = await _mediator.Send(request, cancellationToken);

        if (response == null)
            return BadRequest();

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TransacaoCreateRequest request)
    {
        var createRequest = await _mediator.Send(request);
        return Ok(createRequest);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<TransacaoUpdateResponse>>
        Update(Guid id, TransacaoUpdateRequest request, CancellationToken cancellationToken)
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

        var deleteRequest = new TransacaoDeleteRequest(id.Value);

        var response = await _mediator.Send(deleteRequest, cancellationToken);
        return Ok(response);
    }
}
