using CalculatorLibrary;
using CalculatorLibrary.Operators;
using NUnit.Framework;

namespace CalculatorTests
{
    public class SubtractionOperatorTests
    {
        [Test]
        public void SubstractionOperator_Test()
        {
            // ARRANGE
            var SubstractionOperator = new SubtractionOperator();
            var numbers = new double[] { 8, 2 };

            // ACT
            var calcResult = SubstractionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(6, calcResult.Result);
        }

        [Test]
        public void SubstractionOperatorParamsIsNull_Test()
        {
            // ARRANGE
            var SubstractionOperator = new SubtractionOperator();
            double[] numbers = null;
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = SubstractionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }

        [Test]
        public void SubstractionOperatorParamsOneNumber_Test()
        {
            // ARRANGE
            var SubstractionOperator = new SubtractionOperator();
            double[] numbers = { 2 };
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = SubstractionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }

        [Test]
        public void SubstractionOperatorParamsZeroNumber_Test()
        {
            // ARRANGE
            var SubstractionOperator = new SubtractionOperator();
            double[] numbers = { };
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = SubstractionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }
    }
}
