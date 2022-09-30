using CalculatorLibrary;
using NUnit.Framework;

namespace CalculatorTests
{
    public class OperatorFactoryTests
    {
        [Test]
        public void OperatorFactoryGetOperatorNotNullSuccess_Test()
        {
            var operatorFactory = new OperatorFactory();
            Assert.NotNull(operatorFactory);
        }

        [Test]
        public void OperatorFactory_GetOperatorIsOperator_Success_Test()
        {
            var operatorFactory = new OperatorFactory();
            Assert.IsInstanceOf<IOperatorFactory>(operatorFactory);
        }
    }
}
