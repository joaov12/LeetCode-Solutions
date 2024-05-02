// Runtime 84 ms
// Memory 45.10 MB

public int FindMaxK(int[] nums) 
 {
     Array.Sort(nums);

     int left = 0;
     int right = nums.Length - 1;

     while (left < right)
     {
         if (nums[left] + nums[right] == 0) return nums[right];
         else if (nums[left] + nums[right] > 0) right--;
         else left++;
     }
     return -1;
 }
