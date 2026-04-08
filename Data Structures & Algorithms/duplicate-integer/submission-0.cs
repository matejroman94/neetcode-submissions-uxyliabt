public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> withoutDuplicate = new();
        foreach(var item in nums)
        {
            if(withoutDuplicate.Add(item) == false)
            {
                return true;
            } 
        }
        return false;
    }
}
