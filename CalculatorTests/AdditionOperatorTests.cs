using CalculatorLibrary;
using CalculatorLibrary.Operators;
using NUnit.Framework;

namespace CalculatorTests
{
    public class AdditionOperatorTests
    {
        [Test]
        public void AdditionOperator_Test()
        {
            // ARRANGE
            var additionOperator = new AdditionOperator();
            var numbers = new double[] { 2, 2 };

            // ACT
            var calcResult = additionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(4, calcResult.Result);
        }

        [Test]
        public void AdditionOperatorParamsIsNull_Test()
        {
            // ARRANGE
            var additionOperator = new AdditionOperator();
            double[] numbers = null;
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = additionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }

        [Test]
        public void AdditionOperatorParamsOneNumber_Test()
        {
            // ARRANGE
            var additionOperator = new AdditionOperator();
            double[] numbers = { 2 };
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = additionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }

        [Test]
        public void AdditionOperatorParamsZeroNumber_Test()
        {
            // ARRANGE
            var additionOperator = new AdditionOperator();
            double[] numbers = {};
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = additionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }
    }
}
