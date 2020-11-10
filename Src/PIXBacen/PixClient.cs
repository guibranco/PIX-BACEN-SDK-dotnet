using System;
using System.Threading;
using System.Threading.Tasks;

namespace PIXBacen
{
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

        #endregion
    }
}
