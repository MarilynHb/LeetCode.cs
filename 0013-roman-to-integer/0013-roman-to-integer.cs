public class Solution {
    public int RomanToInt(string s) {
        var result = 0;
        var max = s.Length-1;
        for(int i = 0; i <max+1; i++){
            if(s[i] == 'M'){
                result += 1000;
            }
            else if(s[i] == 'D'){
                result += 500;
            }
            else if(s[i] == 'C'){
                if((i < max) && (s[i+1] == 'D' || s[i+1] == 'M')){
                    result -= 100;
                }
                else{
                    result += 100;
                }
            }
            else if(s[i] == 'L'){
                result += 50;
            }
            else if(s[i] == 'X'){
                if((i < max) && (s[i+1] == 'C' || s[i+1] == 'L')){
                    result -= 10;
                }
                else{
                    result += 10;
                }
            }
            else if(s[i] == 'V'){
                result += 5;
            }
            else if(s[i] == 'I'){
                if((i < max) && (s[i+1] == 'V' || s[i+1] == 'X')){
                    result--;
                }
                else{
                    result++;
                }
            }
        }
        return result;
    }        
}