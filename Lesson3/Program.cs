namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue, secondValue;
            string action;

            Console.WriteLine("Enter first number");
            Int32.TryParse(Console.ReadLine(), out firstValue);

            Console.WriteLine("Enter second number");
            Int32.TryParse(Console.ReadLine(), out secondValue);

            Console.WriteLine("Enter action (+ - / * %)");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine(0);
                        break;
                    }
                    Console.WriteLine(firstValue / secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "%":
                    Console.WriteLine(firstValue % secondValue);
                    break;

                default:
                    Console.WriteLine("Incorrect action entered");
                    break;
            }

            
        }
    }
}