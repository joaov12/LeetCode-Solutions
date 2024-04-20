// Runtime 172 ms
// Memory 75.2 MB


    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();

        Array.Sort(nums);

        for(int i = 0; i < nums.Length - 2; i++) {
            // Evitar duplicatas
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while(left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if(sum == 0) {
                    result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    // Evitar duplicatas
                    while (left < right && nums[left] == nums[left + 1])
                        left++;
                    while (left < right && nums[right] == nums[right - 1])
                        right--;
                    left++;
                    right--;
                } else if(sum > 0) {
                    right--;
                } else {
                    left++;
                }
            }
        }

        return result;  
    }
