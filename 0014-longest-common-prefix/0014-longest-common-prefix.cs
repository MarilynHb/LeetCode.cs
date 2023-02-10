public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var min = 200;
        var minStr = strs[0];
        string commonPref;
        foreach(var str in strs){
            if(str.Length <min){
                min = str.Length;
                minStr = str;
            }
        }
        
        foreach(var str in strs){
            for(int i = 0; i<min; i++){
                if(str[i] != minStr.ElementAt(i)){
                    if(i>0){
                        minStr = minStr.Substring(0, i);
                        min = i;
                    }
                    else{
                        return "";
                    }
                }
            }
        }
        return minStr;
    }
}