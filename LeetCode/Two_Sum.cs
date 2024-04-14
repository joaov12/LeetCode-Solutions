// Runtime 144ms
// Memory 47.33MB

public int[] TwoSum(int[] nums, int target)
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

// - - - - - 


// Second solution


public static int[] TwoSum(int[] nums, int target)
{
    Dictionary map = new Dictionary<int, int>();


    for(int i = 0; i < nums.)
}


