

using MediatR;

namespace SIPConnector.Application.Buy.Commands
{
    public class CreateBuyCommand : IRequest<Guid>
    {
        public int TipoOperacion { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorIVA { get; set; }
        public decimal ValorImpuestoConsumo { get; set; }
        public decimal ValorPropina { get; set; }
        public decimal ValorTotal { get; set; }
        public string? NumeroFactura { get; set; }
        public string? CodigoCajero { get; set; }
        public int TipoCombustible { get; set; }
        public int Kilometraje { get; set; }
        public int Galones { get; set; }
        public string? CodigoTerminal { get; set; }
        public string? NumeroCaja { get; set; }
        public decimal BaseDevolucionIVA { get; set; }
        public decimal BaseImpuestoConsumo { get; set; }
        public string? NumeroReciboCliente { get; set; }
        public int Vigencia { get; set; }
        public string? Persiste { get; set; }
        public string? CodigoUnicoMulticomercio { get; set; }
        public string? Ubicacion { get; set; }
    }
}
