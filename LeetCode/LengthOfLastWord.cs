// Runtime 43 ms
// Memory 38.5 MB

public int LengthOfLastWord(string s) 
{
    s = s.Trim();
    string[] ans = s.Split(' ');
    return ans[ans.Length - 1].Length;
}
