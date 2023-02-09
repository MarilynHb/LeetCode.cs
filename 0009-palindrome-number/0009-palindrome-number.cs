public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0) return false;
        
        int  n = x, reverse=0, rem;     
        while(n!=0)
        {      
        rem=n%10;        
        reverse=reverse*10+rem;      
        n/=10;      
       }     
       if(x == reverse ){
           return true;
       }
        else return false;
    }
}