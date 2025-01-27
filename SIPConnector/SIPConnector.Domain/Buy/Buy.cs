
using SIPConnector.Domain.Common;

namespace SIPConnector.Domain.Buy
{
    public class Buy : AggregateRoot
    {
        public int TipoOperacion { get; private set; }
        public decimal ValorVenta { get; private set; }
        public decimal ValorIVA { get; private set; }
        public decimal ValorImpuestoConsumo { get; private set; }
        public decimal ValorPropina { get; private set; }
        public decimal ValorTotal { get; private set; }
        public string NumeroFactura { get; private set; }
        public string CodigoCajero { get; private set; }
        public int TipoCombustible { get; private set; }
        public int Kilometraje { get; private set; }
        public int Galones { get; private set; }
        public string CodigoTerminal { get; private set; }
        public string NumeroCaja { get; private set; }
        public decimal BaseDevolucionIVA { get; private set; }
        public decimal BaseImpuestoConsumo { get; private set; }
        public string NumeroReciboCliente { get; private set; }
        public int Vigencia { get; private set; }
        public string Persiste { get; private set; }
        public string CodigoUnicoMulticomercio { get; private set; }
        public string Ubicacion { get; private set; }

        private Buy(
            Guid id,
            int tipoOperacion,
            decimal valorVenta,
            decimal valorIVA,
            decimal valorImpuestoConsumo,
            decimal valorPropina,
            decimal valorTotal,
            string numeroFactura,
            string codigoCajero,
            int tipoCombustible,
            int kilometraje,
            int galones,
            string codigoTerminal,
            string numeroCaja,
            decimal baseDevolucionIVA,
            decimal baseImpuestoConsumo,
            string numeroReciboCliente,
            int vigencia,
            string persiste,
            string codigoUnicoMulticomercio,
            string ubicacion) : base(id)
        {
            TipoOperacion = tipoOperacion;
            ValorVenta = valorVenta;
            ValorIVA = valorIVA;
            ValorImpuestoConsumo = valorImpuestoConsumo;
            ValorPropina = valorPropina;
            ValorTotal = valorTotal;
            NumeroFactura = numeroFactura ?? throw new ArgumentNullException(nameof(numeroFactura));
            CodigoCajero = codigoCajero ?? throw new ArgumentNullException(nameof(codigoCajero));
            TipoCombustible = tipoCombustible;
            Kilometraje = kilometraje;
            Galones = galones;
            CodigoTerminal = codigoTerminal ?? throw new ArgumentNullException(nameof(codigoTerminal));
            NumeroCaja = numeroCaja ?? throw new ArgumentNullException(nameof(numeroCaja));
            BaseDevolucionIVA = baseDevolucionIVA;
            BaseImpuestoConsumo = baseImpuestoConsumo;
            NumeroReciboCliente = numeroReciboCliente ?? throw new ArgumentNullException(nameof(numeroReciboCliente));
            Vigencia = vigencia;
            Persiste = persiste ?? throw new ArgumentNullException(nameof(persiste));
            CodigoUnicoMulticomercio = codigoUnicoMulticomercio;
            Ubicacion = ubicacion;
        }

        public static Buy Create(
            int tipoOperacion,
            decimal valorVenta,
            decimal valorIVA,
            decimal valorImpuestoConsumo,
            decimal valorPropina,
            decimal valorTotal,
            string numeroFactura,
            string codigoCajero,
            int tipoCombustible,
            int kilometraje,
            int galones,
            string codigoTerminal,
            string numeroCaja,
            decimal baseDevolucionIVA,
            decimal baseImpuestoConsumo,
            string numeroReciboCliente,
            int vigencia,
            string persiste,
            string codigoUnicoMulticomercio,
            string ubicacion
        )
        {
            if (tipoOperacion != 0)
                throw new ArgumentException("El tipo de operación debe ser 0 (Compra).");

            if (valorVenta <= 0)
                throw new ArgumentException("El valor de la venta debe ser mayor a 0.");

            if (vigencia < 0 || vigencia > 999)
                throw new ArgumentException("La vigencia debe estar entre 0 y 999 minutos.");

            return new Buy(Guid.NewGuid(),
             tipoOperacion,
             valorVenta,
             valorIVA,
             valorImpuestoConsumo,
             valorPropina,
             valorTotal,
             numeroFactura,
             codigoCajero,
             tipoCombustible,
             kilometraje,
             galones,
             codigoTerminal,
             numeroCaja,
             baseDevolucionIVA,
             baseImpuestoConsumo,
             numeroReciboCliente,
             vigencia,
             persiste,
             codigoUnicoMulticomercio,
             ubicacion);
        }
    }
}
