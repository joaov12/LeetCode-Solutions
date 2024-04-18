// Runtime 117 ms
// Memory 50 MB

// Two Sum II - Input Array Is Sorted - Medium 

 public int[] TwoSum(int[] numbers, int target) {
    Dictionary<int, int> dicionario = new Dictionary<int, int>();

    for (int i = 0; i < numbers.Length; i++)
    {
        int complemento = target - numbers[i];
        if (dicionario.ContainsKey(complemento))
        {
            return new int[] { dicionario[complemento] + 1, i + 1 };
        }
        dicionario[numbers[i]] = i;
    }
    return [];
  }
