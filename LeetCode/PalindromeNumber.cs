// Runtime 48 ms
// Memory 31.6 MB

 public bool IsPalindrome(int x)
 {
     if (x < 0)
     {
         return false;
     }

     int reverse = 0;
     int num = x;

     while (num != 0)
     {
         reverse *= 10;
         reverse += (num % 10);
         num /= 10;
     }

     return (x == reverse);
 }
