namespace CalculatorLibrary.Operators
{
    class DivisionOperator : BaseOperator
    {
        protected override CalculatorResult CalculatorInternal(params double[] array)
        {
            CalculatorResult calculatorResult = new CalculatorResult();

            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0 && array[i] == 0)
                    return new CalculatorResult { Error = "ошибка, на 0 делить нельзя " };
                calculatorResult.Result = i == 0 ? array[i] : calculatorResult.Result / array[i];
            }
            return calculatorResult;
        }
    }
}
