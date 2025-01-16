public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        int length;
        s = s.ToLower();

        string newString = "";

        foreach(var c in s)
            if (Char.IsLetterOrDigit(c))
                newString += c;

        length = newString.Length; 

        for (int i = 0 , j = length - 1; i < j; i++, j--)
            if (newString[i] != newString[j])
                    return false;

        /*if (length == 1 || length == 0)
            return true;

        if (length % 2 != 0)
        {
            for (int i = 0, j = length - 1; j <= 0; i++, j--)
                if (newString[i] != newString[j])
                    return false;
        }
        else 
        {
            for (int i = 0, n = length, j = n -1; i != j ; i++, j--)
                if (newString[i] != newString[j])
                    return false;
        }*/

        return true;
        

    }
}