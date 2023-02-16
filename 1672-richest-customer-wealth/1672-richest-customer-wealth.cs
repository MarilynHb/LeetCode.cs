public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;
        foreach(var cust in accounts){
            int custWealth = 0;
            foreach(var bank in cust){
                custWealth += bank;
            }
            maxWealth = Math.Max(custWealth, maxWealth);
        }
        return maxWealth;
    }
}