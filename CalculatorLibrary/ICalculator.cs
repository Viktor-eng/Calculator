namespace CalculatorLibrary
{
    public interface ICalculator
    {
        CalculatorResult Addition(params double[] array);

        CalculatorResult Subtraction(params double[] array);

        CalculatorResult Multiplication(params double[] array);

        CalculatorResult Division(params double[] array);
    }
}
