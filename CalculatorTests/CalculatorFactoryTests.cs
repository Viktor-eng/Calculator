using NUnit.Framework;
using CalculatorLibrary;

namespace CalculatorTests
{
    public class CalcFactoryTests
    {
        [Test]
        public void CalcFactory_GetCalsNotNull_Success_Test()
        {
            var calculator = CalculatorFactory.GetCalculator();
            Assert.NotNull(calculator);
        }

        [Test]
        public void CalcFactory_GetCalsIsICalc_Success_Test()
        {
            var calculator = CalculatorFactory.GetCalculator();
            Assert.IsInstanceOf<ICalculator>(calculator);
        }
    }
}
