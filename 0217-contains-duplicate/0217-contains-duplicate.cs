public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        //sort in ascending order
       Array.Sort(nums);

        //iterate through the array until second last element
        for (int i = 0, length = nums.Length ; i < length - 1; i++ )
            if (nums[i] == nums[i+1]) //retrun true if the current element is equal to the next element
                return true;
        return false;
    }
}