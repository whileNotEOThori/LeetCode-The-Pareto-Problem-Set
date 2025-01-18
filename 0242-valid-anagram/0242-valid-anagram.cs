public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        int s_len = s.Length, t_len = t.Length;
       
       //strings of unequal length cannot be anagrams
        if (s_len != t_len)//retrun false if lengths arent eqaul
            return false;

        for (int i = 0; i < s_len; i++)
        {
            if (!t.Contains(s[i])) //return false if a character is not found in both strings
                return false;
            
            //remove charater if it is present in both strings
            t = t.Remove(t.IndexOf(s[i]),1);
        }

        return true;
    }
}