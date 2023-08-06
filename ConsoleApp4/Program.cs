using System;

namespace practice
{
    class program
    {
        //public int secondmaxnumber(int[] arr)
        //{
        //    int n = arr.length;
        //    int max = arr[0];
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    for (int i = 1; i < n; i++)
        //    {
        //        if (arr[i] < max && )
        //    }
        //}
        int ReverceNumber(int[] arr)
        {
            int[] vs = new int[arr.Length];
            int n = arr.Length;
            int j = 0;
            for (int i = n - 1; i > 0; i--)
            {
               vs[j] = arr[i];
                j++;
            }
            return vs[arr.Length];
        }
        bool FindDuplicate(int[] arr)
        {
            int y = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int refrence = arr[y];
                for (int j = y; j < arr.Length; j++)
                {
                    if (arr[j] == refrence)
                    {
                        return true;
                        break;
                    }
                    else
                    {
                        y++;
                    }
                }
            }
            return false;
        }
        int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] arr = new int[2];
                        return arr[]{ i, j};
                    }
                }
            }
        }
    }
}