namespace PIXBacen.Tests
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using PIXBacen;
    using Xunit;

    public class UnitTest1
    {

        /// <summary>
        /// Tests the GetChargePayloadAsync method of the PixClient class.
        /// </summary>
        /// <remarks>
        /// This unit test verifies that the GetChargePayloadAsync method throws a
        /// <see cref="NotImplementedException"/> when called with an empty string as the first parameter
        /// and a default cancellation token. The test uses the xUnit framework's
        /// <see cref="Assert.ThrowsAsync{T}"/> method to assert that the expected exception is thrown.
        /// This is important for ensuring that the method behaves correctly when given invalid input.
        /// </remarks>
        /// <exception cref="NotImplementedException">
        /// Thrown when the GetChargePayloadAsync method is not implemented.
        /// </exception>
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
