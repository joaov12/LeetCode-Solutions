// Runtime 103 ms
// Memory 46.3 MB

  public  int[] RunningSum(int[] nums)
  {
      for (int i = 1; i < nums.Length; i++)
      {
       nums[i] = nums[i] + nums[i - 1];
      }
      return nums;
  }
