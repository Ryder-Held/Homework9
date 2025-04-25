// Creator: Ryder Held
// Date: 2/25/2025
namespace MajorityElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Major number = new Major();
            int[] nums = { 2, 2, 1, 1, 1, 2, 2};
            Console.WriteLine(number.FindMajor(nums));
        }
    }
}
