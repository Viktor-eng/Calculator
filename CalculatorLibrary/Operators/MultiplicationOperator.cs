namespace CalculatorLibrary.Operators
{
    class MultiplicationOperator : BaseOperator
    {
        protected override CalculatorResult CalculatorInternal(params double[] array)
        {
            CalculatorResult calculatorResult = new CalculatorResult();

            for (int i = 0; i < array.Length; i++)
                calculatorResult.Result = i == 0 ? array[i] : calculatorResult.Result * array[i];
            return calculatorResult;
        }
    }
}
