// Runtime 50 ms
// Memory 41.62 MB

public static string ReversePrefix(string word, char ch) // static for tests
{
  // basicamente: encontrar primeira ocorrencia de ch e fazer o swap do inicio até o ch
  // isso ja foi feito no problema Reverse String, usar mesmo algoritmo, two pointers (dois ponteiros)

  int indexOfCh = word.IndexOf(ch); // Se ch nao existe, é retornado -1
  if (indexOfCh == -1) return word;
      
  char[] wordCharArray = word.ToCharArray();
  int left = 0;
  int right = indexOfCh;

  while(left < right)
  {
     char temp = wordCharArray[left];
     wordCharArray[left] = wordCharArray[right];
     wordCharArray[right] = temp;
     left++;
     right--;
   }
  return new string(wordCharArray);
}
