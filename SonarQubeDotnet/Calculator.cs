namespace PoorNamingAndAccessibility
{
    public class Calculator
    {
        public int Calculate(int a, int b, string operation)
        {
            switch (operation)
            {
                case "add":
                    return a + b;
                case "subtract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    if (b == 0)
                    {
                        throw new DivideByZeroException();  // Issue: Exceção não tratada
                    }
                    return a / b;
                default:
                    throw new InvalidOperationException("Invalid operation."); // Exceção não específica
            }
        }
    }
}
