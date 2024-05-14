// Runtime 129 ms
// Memory 78.9 MB

public IList<IList<string>> GroupAnagrams(string[] strs)
{
    var map = new Dictionary<string, IList<String>>();

    for(int i = 0; i < strs.Length; i++)
    {
        char[] charArrayWord = strs[i].ToCharArray();
        Array.Sort(charArrayWord);
        string sortedWord = new string(charArrayWord);

        if (map.ContainsKey(sortedWord))
        {
            map[sortedWord].Add(strs[i]);
        }
        else
        {
            map.Add(sortedWord, new List<string> { strs[i] });
        }
    }
    return map.Values.ToList();
}
