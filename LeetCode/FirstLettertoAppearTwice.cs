// Runtime 57 ms
// Memory 41.1 MB

public char RepeatedCharacter(string s) 
{
    Dictionary<char, int> map = new Dictionary<char, int>();
       
    for(int i = 0; i < s.Length; i++)
    {
        if(map.ContainsKey(s[i]))
        {
            return s[i];
        }
        map.Add(s[i], i);
    }
    return ' ';
}