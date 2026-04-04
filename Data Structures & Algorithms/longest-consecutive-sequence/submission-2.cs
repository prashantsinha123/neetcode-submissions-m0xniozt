public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hash = new (nums);
        int maxCount =0;
        foreach(int x in hash){
            int count =0;
            if(!hash.Contains(x-1)){
                int temp=x;
                while(hash.Contains(temp)){
                    count++;
                    temp++;
                }
                
            }
            maxCount = Math.Max(maxCount, count);
        }
        return maxCount;
    }
}
