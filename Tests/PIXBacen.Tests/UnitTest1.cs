using Xunit;

namespace PIXBacen.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var c = new Class1();
            var r = c.Method();

            Assert.True(r);
        }
    }
}
