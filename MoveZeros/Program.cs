// Creator: Ryder Held
// Date: 4/24/2025
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MoveZeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ZeroMover zeroMover = new ZeroMover();
            int[] nums = { 0, 1, 0, 3, 12 };
            int[] hold = zeroMover.MoveZeros(nums);
            for (int i = 0; i < hold.Length; i++)
            {
                Console.WriteLine(hold[i]);
            }
        }
    }
}
