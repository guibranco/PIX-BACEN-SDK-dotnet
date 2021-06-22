namespace PIXBacen
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class PixClient : IPixClient
    {
        #region Implementation of IPixClient

        public ValueTask<string> GetChargePayloadAsync(string accessToken, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> GetChargePayloadWithDueDateAsync(string accessToken, string ibgeCode, DateTime desiredPaymentDate,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public ValueTask<CobrancaPayload> PutChargeAsync(string txId, CobrancaPayload charge, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public ValueTask<CobrancaPayload> PatchChargeAsync(string txId, CobrancaPayload charge, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public ValueTask<CobrancaPayload> GetChargeAsync(string txtId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public ValueTask<CobrancaPayload> PostChargeAsync(CobrancaPayload charge, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public ValueTask<CobrancaPayloadList> GetChargesAsync(ChargeFilter filters, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
