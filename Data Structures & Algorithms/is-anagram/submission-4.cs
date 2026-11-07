public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!= t.Length) return false;
        Dictionary<char, int> dict = new();
        foreach(char ch in s){
            if(dict.ContainsKey(ch)) dict[ch]++;
            else dict[ch]=1;
        }

        foreach(char ch in t){
            if(dict.ContainsKey(ch)) dict[ch]--;
            else return false;
            if(dict[ch]<0) return false;
        }
        return true;
    }
}
