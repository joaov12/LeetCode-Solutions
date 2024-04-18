// Runtime 52 ms
// Memory 42.62 MB

public bool IsAnagram(string s, string t)
{
    char[] charS = s.ToCharArray();
    char[] charT = t.ToCharArray();
    Array.Sort(charS);
    Array.Sort(charT);
    return new string(charS) == new string(charT);
}
