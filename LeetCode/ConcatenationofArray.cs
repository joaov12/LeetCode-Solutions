// Runtime 116 ms
// Memory 51 MB


public int[] GetConcatenation(int[] nums)
{
    return nums.Concat(nums).ToArray();
}
