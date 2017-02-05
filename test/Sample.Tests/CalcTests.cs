using Xunit;

namespace Sample.Tests
{
    public class Calc_Should
    {
        [Fact]
        public void AddsTwoNumbersCorrectly()
        {
            var result = new Calc().Add(3, 5);
            Assert.Equal(1, result);
        }
    }
}
