public class Solution {
    public bool IsPalindrome(string s) {
        string str = s.ToLowerInvariant();
        int left =0;
        int right = s.Length-1;
        while(left<right){
            if(!Char.IsLetterOrDigit(str[left])){
                left++;
                continue;
            }
            if(!Char.IsLetterOrDigit(str[right])){
                right--;
                continue;
            }else if(str[left] != str[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
