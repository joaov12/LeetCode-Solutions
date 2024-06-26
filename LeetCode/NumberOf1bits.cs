// Runtime 15 ms
// Memory 27.4 MB 

public int HammingWeight(int n)
{

    string binario = transformDecToBin(n);
    int count1 = 0;
    for (int i = 0; i < binario.Length; i++)
    {
        if (binario[i] == '1')
        {
            count1++;
        }
    }
    return count1;
}

public static string transformDecToBin(int num)
{
    int r = 0;
    string result = "";
    while (num > 0)
    {
        r = num % 2;
        num /= 2;
        result = r.ToString() + result;
    }
    return result;
}
