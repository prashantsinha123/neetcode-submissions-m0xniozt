public class Solution {
    public int MaxProfit(int[] prices) {
        int left =0; int right =1;
        int maxProfit =0;
        while(right< prices.Length){
            if(prices[right]- prices[left]< 0){
                left=right;
            }else{
                maxProfit = Math.Max((prices[right]- prices[left]), maxProfit);
                
            }
            right++;
        }
        return maxProfit;
    }
}
