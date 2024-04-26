// Runtime 24 ms
// Memory 38.9 MB

public int ScoreOfString(string s) 
{
    int sum=0;
    for(int i = 0; i < s.Length - 1; i++)
    {
        sum += Math.Abs(s[i] - s[i+1]);
    }
    return sum;
}
