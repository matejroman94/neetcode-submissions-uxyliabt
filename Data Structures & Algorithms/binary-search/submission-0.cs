public class Solution {
    public int Search(int[] nums, int target) {
        int low, mid, high;
        low = 0;
        high = nums.Length - 1;

        while(low <= high)
        {
            mid = low + (high - low) / 2;
            
            if (target == nums[mid])
            {
                return mid;
            }
            else if (target > nums[mid])
            {
                low = mid + 1;
            }
            else
            { 
                high = mid - 1;
            }
        }
        
        return -1;
    }
}
