public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new();
        List<int> buffer = new();
        foreach(int num in nums){
            if(dict.ContainsKey(num)) dict[num]++;
            else dict[num]=1;
        }
        var dict1 = dict.OrderByDescending(x=>x.Value).Take(k);
        return new List<int>(dict1.Select(x=>x.Key)).ToArray();
    }
}
