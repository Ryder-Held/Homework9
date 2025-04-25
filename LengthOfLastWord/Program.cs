// Creator: Ryder Held
// Date: 2/24/2025
namespace LengthOfLastWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "   fly me   to   the moon  ";
            int count = 0;
            int hold = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    count++;
                }

                try
                {
                    if (s[i] == ' ' && s[i - 1] != ' ')
                    {
                        hold = count;
                        count = 0;
                    }
                }
                catch { }
            }

            if (s[s.Length - 1] == ' ')
            {
                count = hold;
            }

            Console.WriteLine(count);
        }
    }
}
