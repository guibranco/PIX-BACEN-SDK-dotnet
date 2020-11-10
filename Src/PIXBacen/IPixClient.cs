using System;
using System.Threading;
using System.Threading.Tasks;

namespace PIXBacen
{
    public interface IPixClient
    {
        ValueTask<string> GetChargePayloadAsync(string accessToken, CancellationToken cancellationToken);

        ValueTask<string> GetChargePayloadWithDueDateAsync(string accessToken, string ibgeCode,
            DateTime desiredPaymentDate, CancellationToken cancellationToken);
    }
}
