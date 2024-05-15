// Runtime 97 ms
// Memory 45.73 MB

public int RemoveElement(int[] nums, int val) {
  int ans = 0; 

  foreach(var i in nums){
    if(i != val){
    nums[ans] = i;
    ans++;
    }
  }
  return ans;
}
