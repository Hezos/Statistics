namespace Common
{
    public class Calculator
    {
        public string Operation { get; set; } = "";
        public double Value { get; set; } = 0;
        public Calculator(string operation, double value)
        {
            Operation = operation;
            Value = value;
        }
    }
}