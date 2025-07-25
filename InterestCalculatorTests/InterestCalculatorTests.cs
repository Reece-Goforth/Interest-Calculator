using InterestCalculator;

namespace InterestCalculatorTests
{
    [TestClass]
    public class InterestCalculatorTests
    {
        [TestMethod]
        public void CalculatesCorrectValue()
        {
            // Arrange
            float initialAmount = 100f;
            float interestRate = .1f;
            int numMonths = 1;
            float expected = 110f;

            // Act
            float actual = InterestCalculatorClass.Calculate(numMonths, initialAmount, interestRate);

            Assert.AreEqual(expected, actual, "Actual amount is not as expected");
        }
    }
}
