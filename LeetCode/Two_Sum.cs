// Runtime 144ms
// Memory 47.33MB

public static int[] TwoSum(int[] nums, int target)
{
    int n = nums.Length;

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return [i,j];
            }
        }
    }
    return [];
}


// - - - - - //

// Runtime 89ms
// Memory 48.15MB

public int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> dicionario = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complemento = target - nums[i];
        if (dicionario.ContainsKey(complemento))
        {
            return new int[] { dicionario[complemento], i };
        }
        dicionario[nums[i]] = i;
    }
    return [];
}



