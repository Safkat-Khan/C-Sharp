using System;

namespace exercise_99
{
    public class DecreasingCounter
    {
        private int value;

        public DecreasingCounter(int initialValue)
        {
            this.value = initialValue;
        }

        public void PrintValue()
        {
            Console.WriteLine("value: " + this.value);
        }

        public void Decrement()
        {
            // Decrements the value of the counter by one if it's greater than 0
            if (this.value > 0)
            {
                this.value--;
            }
        }

        public void Reset()
        {
            // Resets the value of the counter to 0
            this.value = 0;
        }

        public static void Main(string[] args)
        {
            // Example usage
            DecreasingCounter counter = new DecreasingCounter(10);
            counter.PrintValue();
            counter.Decrement();
            counter.PrintValue();
            counter.Decrement();
            counter.PrintValue();

            counter = new DecreasingCounter(2);
            counter.PrintValue();
            counter.Decrement();
            counter.Decrement();
            counter.PrintValue();
            counter.Decrement();
            counter.PrintValue();
            


            counter = new DecreasingCounter(20);
            counter.PrintValue();
            counter.Reset();
            counter.PrintValue();
        }
    }
}
