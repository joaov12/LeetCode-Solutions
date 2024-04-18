// Runtime 187 ms
// Memory 67.37 MB

    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] rigth = new int[nums.Length]; // Produtos da esquerda pra DIREITA
        int[] left = new int[nums.Length]; // Produtos da direita pra ESQUERDA

        rigth[0] = 1;
        left[nums.Length - 1] = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            rigth[i] = nums[i - 1] * rigth[i - 1];
        }

        for(int i = nums.Length - 2; i >= 0; i--)
        {
            left[i] = nums[i + 1] * left[i + 1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rigth[i] * left[i];
        }
      
        return nums;
    }
