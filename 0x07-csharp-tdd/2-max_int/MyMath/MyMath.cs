using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> Operations</summary>

    public class Operations
    {
        /// <summary> Max int</summary>
        public static int Max(List<int> nums)
        {

            if (nums == null || nums.Count <= 0)
                return 0;

            int cnt = 1;
            int maxi = nums[0];
            while (cnt < nums.Count) 
            {
                if (nums[cnt] > maxi) 
                {
                    maxi = nums[cnt];
                }
                cnt++;
            }
            return maxi;
        }
    }
}
