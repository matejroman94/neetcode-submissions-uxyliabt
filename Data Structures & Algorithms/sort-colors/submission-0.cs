public class Solution {
    public void SortColors(int[] nums) {
        Sort(nums,3);
    }

    public static void Sort(int[] nums, int numOfElements)
    {
        int[] bucket = new int[numOfElements];
        foreach (var num in nums)
        {
            bucket[num]++;
        }

        int j = 0;
        for (int index = 0; index < bucket.Length; index++)
        {
            for (int countIndex = 0; countIndex < bucket[index]; countIndex++)
            {
                nums[j++] = index;
            }
        }
    }
}