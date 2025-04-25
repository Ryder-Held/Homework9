// Creator: Ryder Held
// Date: 2/25/2025
namespace ReverseString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Reverse reverse = new Reverse();
            char[] s = { 'H', 'a', 'n', 'n', 'a', 'h' };
            Console.WriteLine(reverse.StringReverse(s));
        }
    }
}
