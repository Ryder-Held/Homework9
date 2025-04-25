// Creator: Ryder Held
// Date: 4/25/2025
namespace HappyNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FindHappy findHappy = new FindHappy();
            int n = 2;
            Console.WriteLine(findHappy.HappyFinder(n));
        }
    }
}
