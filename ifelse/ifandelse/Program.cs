namespace ifandelse
{
    internal class Program
    {
        private static int firstNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("If and else nesting");

            int first = 7, second = -23, third = 13;
            if (first > second)
            {
                if (firstNumber > third)
                {
                    Console.WriteLine("{0} is the largest", first);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("{0} is the largest", second);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", third);
                }
            }
        }
    }
}
