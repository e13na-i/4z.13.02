namespace lylkdhjlhjlnkb
{
    internal class Program
    {
        static bool isEven(int n)
        {
            if (n %2==0) 
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("number= ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(isEven(num));
        }

    }
}
