// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    public class Major
    {
        public int FindMajor(int[] nums)
        {
            int count = 0;
            int hold = 0;
            int diff = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        count = nums[i];
                        hold++;
                    }
                    else
                    {
                        diff = nums[j];
                    }
                }
            }

            if (hold > nums.Count() / 2)
            {
                return count;
            }
            else
            {
                return diff;
            }
        }
    }
}
