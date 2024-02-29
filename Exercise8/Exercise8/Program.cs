namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Max Number ");

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i+=2);
            {
                Console.WriteLine ( number);
            }
        }
    }
}