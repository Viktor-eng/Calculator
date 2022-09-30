using CalculatorLibrary;
using CalculatorLibrary.Operators;
using NUnit.Framework;

namespace CalculatorTests
{
    public class MultiplicationOperatorTests
    {
        [Test]
        public void MultiplicationOperator_Test()
        {
            // ARRANGE
            var MultiplicationOperator = new MultiplicationOperator();
            var numbers = new double[] { 2, 2 };

            // ACT
            var calcResult = MultiplicationOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(4, calcResult.Result);
        }

        [Test]
        public void MultiplicationOperatorParamsIsNull_Test()
        {
            // ARRANGE
            var MultiplicationOperator = new MultiplicationOperator();
            double[] numbers = null;
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = MultiplicationOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }

        [Test]
        public void MultiplicationOperatorParamsOneNumber_Test()
        {
            // ARRANGE
            var MultiplicationOperator = new MultiplicationOperator();
            double[] numbers = { 2 };
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = MultiplicationOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }

        [Test]
        public void MultiplicationOperatorParamsZeroNumber_Test()
        {
            // ARRANGE
            var MultiplicationOperator = new MultiplicationOperator();
            double[] numbers = { };
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = MultiplicationOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }
    }
}
