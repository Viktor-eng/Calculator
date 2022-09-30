using System;

namespace CalculatorLibrary.Operators
{
    abstract class BaseOperator : IOperator
    {
        abstract protected CalculatorResult CalculatorInternal(params double[] array);

        public CalculatorResult Calc(params double[] array)
        {
            try
            {
                ValidateInputParameters(array);
            }
            catch (ArgumentException ae)
            {
                return new CalculatorResult { Error = ae.Message };
            }
            return CalculatorInternal(array);
        }

        protected void ValidateInputParameters(params double[] array)
        {
            if (Convert.ToInt32(array?.Length) < 2)
                throw new ArgumentException("для выполнения операции необходимо ввести минимум 2 числа!");
        }
    }
}
