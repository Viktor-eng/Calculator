namespace CalculatorLibrary
{
    interface IOperator
    {
        CalculatorResult Calc(params double[] array);
    }
}
