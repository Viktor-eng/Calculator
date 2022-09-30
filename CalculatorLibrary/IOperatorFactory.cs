namespace CalculatorLibrary
{
    interface IOperatorFactory
    {
        IOperator GetOperator(TypeOperator typeOperator);
    }
}
