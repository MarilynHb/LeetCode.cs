public class Solution {
    public int isOdd(int nb){
        if(nb%2 != 0){
            return 1;
        }
        return 0;
    }
    public int CountOdds(int low, int high) {
        int result = 0;
        for(int i = low; i<=high; i++){
            result += isOdd(i);
        }
        return result;
    }
}