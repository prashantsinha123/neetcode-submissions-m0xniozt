public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>(nums);
        if(seen.Count!= nums.Length) return true;
        return false;
    }
}