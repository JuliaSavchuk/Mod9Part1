namespace Mod9Part1
{
    public delegate void MessageDelegate(string message);

    internal class Task2
    {
        public void ShowCurrentTime()
        {
            Console.WriteLine($"Current Time: {DateTime.Now.ToString("HH:mm:ss")}");
        }

        public void ShowCurrentDate()
        {
            Console.WriteLine($"Current Date: {DateTime.Now.ToString("yyyy-MM-dd")}");
        }

        public void ShowCurrentDayOfWeek()
        {
            Console.WriteLine($"Current Day of Week: {DateTime.Now.DayOfWeek}");
        }

        public double CalculateTriangleArea(double @base, double height)
        {
            return 0.5 * @base * height;
        }

        public double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
