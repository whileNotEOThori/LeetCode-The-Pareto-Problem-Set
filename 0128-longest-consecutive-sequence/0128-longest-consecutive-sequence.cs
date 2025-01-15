public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {
        int length = nums.Length;
        int start_pos = -1;
        int end_pos = -1;
        List<string> sequences = new List<string>(); //startpos#endpos
        List<int> lengthOfSequences = new List<int>(); //startpos#endpos
        bool is_consecutive = false;
        string sequence;
        int lengthOfSequence = 1;

        //sort array in asceding order
        Array.Sort(nums);

        if (length == 0)
         return 0;

        for (int i = 0; i < length-1; i++)
        {
            if (is_consecutive)
            {
                if (nums[i] == nums[i+1])
                    continue;

                if (nums[i+1] != nums[i]+1) //sequence ends
                {
                    is_consecutive = false;
                    end_pos = i;  
                                        
                    sequence = $"{start_pos}#{end_pos}"; 
                    sequences.Add(sequence);

                    lengthOfSequences.Add(lengthOfSequence);

                    start_pos = -1;
                    end_pos = -1;
                    lengthOfSequence = 1;
                }
                else
                {
                    lengthOfSequence++;
                }
            }
            else
            {
                if (nums[i+1] == nums[i]+1)
                {
                    is_consecutive = true;
                    start_pos = i;
                    lengthOfSequence++;
                }
            }
           

            
        }
        lengthOfSequences.Add(lengthOfSequence);

        lengthOfSequences.Sort();

        if (lengthOfSequences.Count == 0)
        {
            return 0; // or any other appropriate default value
        }

        return lengthOfSequences[lengthOfSequences.Count - 1];

    }
}