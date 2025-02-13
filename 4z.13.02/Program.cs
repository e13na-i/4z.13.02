namespace _4z._13._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int Power(int a, int b)
            {
                if (b == 0)
                    return 1;
                return a * Power(a, b - 1);
            }

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine($"{A}^{B} = {Power(A, B)}");
        }
    }
}
