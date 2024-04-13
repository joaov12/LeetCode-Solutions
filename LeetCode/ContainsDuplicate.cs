// Runtime 271ms
//Memory 69.48MB


public bool ContainsDuplicate(int[] nums)
{
    Dictionary<int, int> dicionario = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (dicionario.ContainsKey(nums[i]))
        {
            return true;
        }
        dicionario.Add(nums[i], i);
    }
    return false;
}
