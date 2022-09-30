namespace CalculatorLibrary
{
    public class CalculatorResult
    {
        public double Result { get; set; }

        public string Error { get; set; }

        public override string ToString()
        {
            return Error ?? Result.ToString();
        }
    }
}
