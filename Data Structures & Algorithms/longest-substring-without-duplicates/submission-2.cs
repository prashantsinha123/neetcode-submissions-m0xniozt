public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int right =0;
        int maxCount = 0;
        for(int i =0; i< s.Length; i++){
            HashSet<int> set = new();
            int count =0;
            while(right<s.Length){
                
                if(!set.Contains(s[right])){
                    set.Add(s[right]);
                    right++;
                    count++;
                } else {
                    right =i+1;
                    break;
                    }
            }
            maxCount = Math.Max(count, maxCount);
        }
        return maxCount;
    }
}
