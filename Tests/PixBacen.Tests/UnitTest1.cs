namespace PIXBacen.Tests
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using PIXBacen;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var client = new PixClient();

            await Assert.ThrowsAsync<NotImplementedException>(
                async () => await client.GetChargePayloadAsync(string.Empty, CancellationToken.None)
            );
        }
    }
}
