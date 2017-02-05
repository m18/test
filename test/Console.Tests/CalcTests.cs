using Xunit;

namespace Console.Tests
{
    public class CalcTests
    {
        [Fact]
        public void AddShouldAddTwoNumbersCorrectly()
        {
            var result = new Calc().Add(3, 5);
            Assert.Equal(8, result);
        }
    }

    // alternative: class Calc_AddShould, method AddTwoNumbersCorrectly()
}
