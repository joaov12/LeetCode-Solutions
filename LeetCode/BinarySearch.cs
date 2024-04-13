// Runtime 147ms
// Memory 51.09MB

public int Search(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left <= right)
    {
        int center = (left + right) / 2;
        if (nums[center] == target)
        {
            return center;
        }
        else if (target < nums[center])
        {
            right = center - 1;
        }
        else
        {
            left = center + 1;
        }
    }
    return -1;
}
