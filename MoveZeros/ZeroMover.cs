// Creator: Ryder Held
// Date: 4/24/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    public class ZeroMover
    {
        public int[] MoveZeros(int[] nums)
        {
            int nonZero = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZero] = nums[i];
                    nonZero++;
                }
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (j >= nonZero)
                {
                    nums[j] = 0;
                }
            }

            return nums;
        }
    }
}
