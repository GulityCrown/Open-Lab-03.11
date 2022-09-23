using System;
using System.Linq;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string reversed;
            char[] s = str.ToCharArray();
            Array.Reverse(s);
            reversed = new string(s);
            if (str == reversed)
                return true;
            else
                return false;
                
            

        } 
    }
}
