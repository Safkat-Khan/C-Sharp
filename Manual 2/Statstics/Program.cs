using exercise_105;

namespace exercise_105
{
    public class Statistics
    {
        public int count { get; set; }
        public int sum { get; set; }

        public Statistics()
        {
            count = 0;
            sum = 0;
        }

        public void AddNumber(int number)
        {
            // Update count and sum when a number is added
            count++;
            sum += number;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Statistics statistics = new Statistics();
        statistics.AddNumber(3);
        statistics.AddNumber(5);
        statistics.AddNumber(1);
        statistics.AddNumber(2);

        Console.WriteLine("Count: " + statistics.count);
        Console.WriteLine("Sum: " + statistics.sum);
    }
}


