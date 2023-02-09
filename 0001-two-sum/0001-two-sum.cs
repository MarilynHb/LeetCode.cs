public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> solutions = new List<int>();
        for(int i = 0; i < nums.Length ; i++){
            for (int j = i + 1 ; j <nums.Length; j++){
                if(nums[i]+nums[j] == target){
                    solutions.Add(i);
                    solutions.Add(j);
                }
            }
        }
        var solArr = solutions.ToArray();
        return solArr;
    }
}