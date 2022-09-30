namespace CalculatorLibrary
{
    internal class Calculator : ICalculator
    {
        IOperatorFactory operatorFactory = new OperatorFactory();

        public CalculatorResult Addition(params double[] array)
        => operatorFactory.GetOperator(TypeOperator.Addition).Calc(array);

        public CalculatorResult Division(params double[] array)
        => operatorFactory.GetOperator(TypeOperator.Division).Calc(array);

        public CalculatorResult Multiplication(params double[] array)
        => operatorFactory.GetOperator(TypeOperator.Multiplication).Calc(array);

        public CalculatorResult Subtraction(params double[] array)
        => operatorFactory.GetOperator(TypeOperator.Subtraction).Calc(array);
    }
}
