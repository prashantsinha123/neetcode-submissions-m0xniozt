public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        Dictionary<int, int> set = new Dictionary<int, int>();
        for(int i=0;i<nums.Length; i++){
            if(set.ContainsKey(target-nums[i])){
                return new int[] {set[target-nums[i]], i};
            }else set[nums[i]] = i;
        }
        return result;
    }
}