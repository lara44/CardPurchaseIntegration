
using MediatR;
using Microsoft.Extensions.Logging;
using SIPConnector.Domain.Buy;
using SIPConnector.Domain.Buy.Repositories;

namespace SIPConnector.Application.Buy.Commands
{
    public class CreateBuyCommandHandler : IRequestHandler<CreateBuyCommand, Guid>
    {
        private readonly IBuyRepository _buyRepository;
        private readonly ILogger<CreateBuyCommandHandler> _logger;

        public CreateBuyCommandHandler(
            IBuyRepository buyRepository,
            ILogger<CreateBuyCommandHandler> logger
        )
        { 
            _buyRepository = buyRepository;
            _logger = logger;
        }

        public async Task<Guid> Handle(CreateBuyCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Inicia proceso de compra con tarjeta");
            var buy = Domain.Buy.Buy.Create(
               request.TipoOperacion,
               request.ValorVenta,
               request.ValorIVA,
               request.ValorImpuestoConsumo,
               request.ValorPropina,
               request.ValorTotal,
               request.NumeroFactura!,
               request.CodigoCajero!,
               request.TipoCombustible,
               request.Kilometraje,
               request.Galones,
               request.CodigoTerminal!,
               request.NumeroCaja!,
               request.BaseDevolucionIVA,
               request.BaseImpuestoConsumo,
               request.NumeroReciboCliente!,
               request.Vigencia,
               request.Persiste!,
               request.CodigoUnicoMulticomercio!,
               request.Ubicacion!
           );

            _logger.LogInformation("fin proceso de compra con tarjeta");
            return buy.Id;
        }
    }
}
