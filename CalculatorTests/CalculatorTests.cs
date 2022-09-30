using CalculatorLibrary;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
    class CalculatorTests
    {
        [Test]
        public void CheckAdditionFactory_Test()
        {
            // ARRANGE
            var calculator = CalculatorFactory.GetCalculator();
            var operatorFactory = new OperatorFactory();
            
            // ACT
            double[] array = { 1, 2, 3 };
            var addOp = operatorFactory.GetOperator(TypeOperator.Addition).Calc(array);
            var addOpMethod = calculator.Addition(array);

            //ASSERT
            Assert.AreEqual(addOpMethod.Result, addOp.Result);
        }

        [Test]
        public void CheckDivisionFactory_Test()
        {
            // ARRANGE
            var calculator = CalculatorFactory.GetCalculator();
            var operatorFactory = new OperatorFactory();

            // ACT
            double[] array = { 8, 4, 2};
            var divOp = operatorFactory.GetOperator(TypeOperator.Division).Calc(array);
            var divOpMethod = calculator.Division(array);

            //ASSERT
            Assert.AreEqual(divOpMethod.Result, divOp.Result);
        }

        [Test]
        public void CheckMultiplicationFactory_Test()
        {
            // ARRANGE
            var calculator = CalculatorFactory.GetCalculator();
            var operatorFactory = new OperatorFactory();

            // ACT
            double[] array = { 8, 4, 2 };
            var multiOp = operatorFactory.GetOperator(TypeOperator.Multiplication).Calc(array);
            var multiOpMethod = calculator.Multiplication(array);

            //ASSERT
            Assert.AreEqual(multiOpMethod.Result, multiOp.Result);
        }

        [Test]
        public void CheckSubtractionFactory_Test()
        {
            // ARRANGE
            var calculator = CalculatorFactory.GetCalculator();
            var operatorFactory = new OperatorFactory();

            // ACT
            double[] array = { 8, 4, 2 };
            var subOp = operatorFactory.GetOperator(TypeOperator.Subtraction).Calc(array);
            var subOpMethod = calculator.Subtraction(array);

            //ASSERT
            Assert.AreEqual(subOpMethod.Result, subOp.Result);
        }

        [Test]
        public void CheckCalculatorResultNull_Test()
        {
            // ARRANGE
            var errorIsNul = new CalculatorResult() { Error = "для выполнения операции необходимо ввести минимум 2 числа!" };

            // ACT 
            var error = errorIsNul.ToString();

            // ASSERT
            Assert.AreEqual(errorIsNul.Error, error) ;
        }

        [Test]
        public void CheckCalculatorResultStringNull_Test()
        {
            // ARRANGE
            var errorIsNul = new CalculatorResult() { Result = 5 };

            // ACT 
            var error = errorIsNul.ToString();

            // ASSERT
            Assert.AreEqual(Convert.ToString(errorIsNul.Result), error);
        }
    }
}
