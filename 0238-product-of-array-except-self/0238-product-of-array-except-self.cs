public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        int length = nums.Length;
        int[] answer = new int[length];
        int product = 1, prod;
        bool zeroPresent = false;

        foreach(int num in nums)
            if (num == 0)
                zeroPresent = true;
            else
                product*= num;

        if (zeroPresent)
        {
            for (int i = 0 ; i < length; i++)
            {
                prod = 1;
                if (nums[i] != 0)
                    answer[i] = 0;
                else
                {
                    for (int j = 0 ; j < length; j++)
                        if (i != j)
                        prod *= nums[j];
                    answer[i] = prod;
                }
            }
        }
        else
            for (int i = 0 ; i < length; i++)
                answer[i] = product/nums[i];
        
    return answer;
    }
}