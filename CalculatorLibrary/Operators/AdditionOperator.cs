using System.Linq;

namespace CalculatorLibrary.Operators
{
    class AdditionOperator : BaseOperator
    {
        protected override CalculatorResult CalculatorInternal(params double[] array)
        {
            return new CalculatorResult { Result = array.Sum() };
        }
    }
}
