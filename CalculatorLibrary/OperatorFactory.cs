using CalculatorLibrary.Operators;
using System;

namespace CalculatorLibrary
{
    class OperatorFactory : IOperatorFactory
    {
        public IOperator GetOperator(TypeOperator typeOperator)
        {
            switch (typeOperator)
            {
                case TypeOperator.Addition:
                    return new AdditionOperator();
                case TypeOperator.Subtraction:
                    return new SubtractionOperator();
                case TypeOperator.Multiplication:
                    return new MultiplicationOperator();
                case TypeOperator.Division:
                    return new DivisionOperator();

                default:
                    throw new ArgumentException("Неизвестный тип оператора");
            }
        }
    }
}
