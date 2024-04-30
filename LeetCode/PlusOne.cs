public int[] PlusOne(int[] digits)  
{
    for(int i = digits.Length - 1;  i >= 0; i--)
    {
        if (digits[i] == 9)
        {
            digits[i] = 0;
        }
        else
        {
            digits[i]++;
            return digits;
        }
    }
    // quando digits só tiver 9 ex: 999, 99, 99999
    int[] onlyNine = new int[] { 1 };
    return onlyNine.Concat(digits).ToArray();

}
