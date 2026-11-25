public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (dict.TryAdd(nums[i], i)) {
                continue;
            }
            return true;
        }
        return false;
    }
}