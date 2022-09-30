using CalculatorLibrary;
using CalculatorLibrary.Operators;
using NUnit.Framework;

namespace CalculatorTests
{
    public class DivisionOperatorTests
    {
        [Test]
        public void DivisionOperator_Test()
        {
            // ARRANGE
            var divisionOperator = new DivisionOperator();
            var numbers = new double[] { 8, 2 };

            // ACT
            var calculatorResult = divisionOperator.Calc(8, 2);

            //ACCERT 
            Assert.AreEqual(4, calculatorResult.Result);
        }

        [Test]
        public void DivisionOperatorIsNull_Test()
        {
            // ARRANGE
            var divisionOperator = new DivisionOperator();
            double[] numbers = null;
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = divisionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }

        [Test]
        public void DivisionOperatorOneNumber_Test()
        {
            // ARRANGE
            var divisionOperator = new DivisionOperator();
            double[] numbers = { 2 };
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = divisionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }

        [Test]
        public void DivisionOperatorZeroNumber_Test()
        {
            // ARRANGE
            var divisionOperator = new DivisionOperator();
            double[] numbers = {};
            var endResult = new CalculatorResult { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT
            var calcResult = divisionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }

        [Test]
        public void DivisionByZero_Test()
        {
            // ARRANGE
            var divisionOperator = new DivisionOperator();
            double[] numbers = {1,0,0};
            var endResult = new CalculatorResult { Error = "ошибка, на 0 делить нельзя " };

            // ACT
            var calcResult = divisionOperator.Calc(numbers);

            // ASSERT
            Assert.AreEqual(endResult.Error, calcResult.Error);
        }
    }
}
