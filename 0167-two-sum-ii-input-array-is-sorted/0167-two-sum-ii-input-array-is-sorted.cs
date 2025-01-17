public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int length = numbers.Length;
        int[] result  = {-1,-1};

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = i+1; j < length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    result[0] =i+1;
                    result[1] =j+1;
                    return result;
                }
            }
        }

        /*//14 / 24 testcases passed
        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - 1; j++)
            {
                if (i == j)
                    continue;
                
                if (numbers[i] + numbers[j] == target)
                {
                    if (i < j)
                    {
                        result[0] =i+1;
                        result[1] =j+1;
                    }
                    else
                    {
                        result[0] =j+1;
                        result[1] =i+1;
                    }

                    return result;
                }
            }
        }*/

        return result;
    }
}