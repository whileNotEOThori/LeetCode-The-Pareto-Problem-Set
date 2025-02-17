public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int start = 0, end = nums.Length-1, middle;
        
        while (start <= end)
        {
            middle = start + (end-start)/2;

            if (nums[middle] == target)
                return middle;
            else if (nums[middle] < target)
                start = middle+1;
            else if (nums[middle]> target)
                end = middle-1;
        }
        return -1;
    }
}