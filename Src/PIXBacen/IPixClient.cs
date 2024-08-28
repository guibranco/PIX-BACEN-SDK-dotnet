namespace PIXBacen
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IPixClient
    {
        ValueTask<string> GetChargePayloadAsync(
            string accessToken,
            CancellationToken cancellationToken
        );

        ValueTask<string> GetChargePayloadWithDueDateAsync(
            string accessToken,
            string ibgeCode,
            DateTime desiredPaymentDate,
            CancellationToken cancellationToken
        );

        ValueTask<CobrancaPayload> PutChargeAsync(
            string txId,
            CobrancaPayload charge,
            CancellationToken cancellationToken
        );

        ValueTask<CobrancaPayload> PatchChargeAsync(
            string txId,
            CobrancaPayload charge,
            CancellationToken cancellationToken
        );

        ValueTask<CobrancaPayload> GetChargeAsync(
            string txtId,
            CancellationToken cancellationToken
        );

        ValueTask<CobrancaPayload> PostChargeAsync(
            CobrancaPayload charge,
            CancellationToken cancellationToken
        );

        ValueTask<CobrancaPayloadList> GetChargesAsync(
            ChargeFilter filters,
            CancellationToken cancellationToken
        );
    }
}
