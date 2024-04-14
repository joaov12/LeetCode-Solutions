// Runtime 70 ms
// Memory 47.7 MB

public bool IsPalindrome(string s) 
{
    System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");
    s = rgx.Replace(s.ToLower(),"");
    int left = 0;
    int right = s.Length - 1;

    while(left <= right)
    {
        if (s[left] == s[right])
        {
           left++;  
            right--;
        }
        else
        {
            return false;
        }
    }
    return true;
}