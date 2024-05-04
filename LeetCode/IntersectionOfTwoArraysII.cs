   // Runtime 102 ms
   // Memory 46.01 MB

    public int[] Intersect(int[] nums1, int[] nums2) 
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        List<int> ans = new List<int>();

        int indexNums1 = 0, indexNums2 = 0;

        while(indexNums1 < nums1.Length && indexNums2 < nums2.Length)
        {
            if(nums1[indexNums1] == nums2[indexNums2])
            {
                ans.Add(nums1[indexNums1]);
                indexNums1++;
                indexNums2++;
            }
            else if(nums1[indexNums1] < nums2[indexNums2])
            {
                indexNums1++;
            }
            else
            {
                indexNums2++;
            }
        }
        return ans.ToArray();
    }
