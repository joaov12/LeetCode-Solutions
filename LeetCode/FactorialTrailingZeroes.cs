// Runtime 21 ms
// Memory 26.7 MB

public int TrailingZeroes(int n) {
    int ans = 0;

    while(n >= 5){
        n /= 5;
        ans += n;
    }
    return ans;
}
