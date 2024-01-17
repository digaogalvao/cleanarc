using AutoMapper;
using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;

namespace FinancialManagement.Application.UseCases.RelatorioDiarioGetByData
{
    public class RelatorioDiarioGetByDataHandler :
        BaseHandler<RelatorioDiarioGetByDataRequest, RelatorioDiarioGetByDataResponse, RelatorioDiario>
    {
        public RelatorioDiarioGetByDataHandler(IRelatorioDiarioRepository relatorioDiarioRepository, IMapper mapper)
        : base(null, relatorioDiarioRepository, mapper) // IUnitOfWork não é necessário para leitura
        {
        }

        public override async Task<RelatorioDiarioGetByDataResponse> Handle(RelatorioDiarioGetByDataRequest request, CancellationToken cancellationToken)
        {
            // Lógica para obter as transações do dia e calcular o saldo final diário

            var transacoesDoDia = await _Repository.RelatorioDiarioGetByData(request.Data);

            decimal saldoFinal = 0;

            foreach (var transacao in transacoesDoDia)
            {
                saldoFinal += transacao.Valor;
            }

            var response = new RelatorioDiarioGetByDataResponse
            {
                Data = request.Data,
                SaldoFinal = saldoFinal
            };

            return response;
        }
    }

}
