namespace Mod9Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 13, 21, 34, 55, 89 };

            ArrayProcessor processor = new ArrayProcessor();

            ArrayOperation operation = processor.GetEvenNumbers;
            Console.WriteLine("Even Numbers: " + string.Join(", ", operation(array)));

            operation = processor.GetOddNumbers;
            Console.WriteLine("Odd Numbers: " + string.Join(", ", operation(array)));

            operation = processor.GetPrimeNumbers;
            Console.WriteLine("Prime Numbers: " + string.Join(", ", operation(array)));

            operation = processor.GetFibonacciNumbers;
            Console.WriteLine("Fibonacci Numbers: " + string.Join(", ", operation(array)));

            //Task2
            Task2 task1 = new Task2();

            Action showTime = task1.ShowCurrentTime;
            Action showDate = task1.ShowCurrentDate;
            Action showDayOfWeek = task1.ShowCurrentDayOfWeek;

            showTime();
            showDate();
            showDayOfWeek();

           
            Func<double, double, double> calculateTriangleArea = task1.CalculateTriangleArea;
            Func<double, double, double> calculateRectangleArea = task1.CalculateRectangleArea;

            double triangleArea = calculateTriangleArea(3, 4);
            double rectangleArea = calculateRectangleArea(5, 6);

            Console.WriteLine($"Triangle Area: {triangleArea}");
            Console.WriteLine($"Rectangle Area: {rectangleArea}");

            CreditCard card = new CreditCard("1234 5678 9101 1121", "John Doe", new DateTime(2025, 12, 31), "1234", 5000, 1000);

            card.AccountReplenished += MessageInConsole;
            card.FundsWithdrawn += MessageInConsole;
            card.CreditLimitReached += MessageInConsole;
            card.PinChanged += MessageInConsole;

            card.ReplenishAccount(200);      
            card.WithdrawFunds(150);          
            card.WithdrawFunds(2000);         
            card.ChangePin("4321");           
        }

        public static void MessageInConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}