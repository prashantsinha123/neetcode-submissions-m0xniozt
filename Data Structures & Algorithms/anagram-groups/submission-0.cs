public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagrams = new ();
        foreach(string str in strs){
            int[] count = new int[26];
            foreach(char ch in str){
                count[ch - 'a']++;
            }
            StringBuilder sb = new();
            for(int i =0 ; i<26; i++){
                sb.Append("#");
                sb.Append(count[i]);
            }
            string key = sb.ToString();
            if(!anagrams.ContainsKey(key)){
                anagrams[key] = new List<string>();
            }
            anagrams[key].Add(str);
        }
        return new List<List<string>>(anagrams.Values);
    }
}
