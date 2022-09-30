namespace CalculatorLibrary
{
    public class CalculatorFactory
    {
        public static ICalculator GetCalculator()
        {
            return new Calculator();
        }
    }
}
