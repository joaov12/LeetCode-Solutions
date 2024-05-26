// Weekly Contest 399
// Runtime: 7 ms
// Memory Usage: 41.2 MB

int numberOfPairs(vector<int>& a, vector<int>& b, int k) {
    int count = 0;

    for (int i : nums1) {
        for (int j : nums2) {
            if (i % (j * k) == 0) {
                count++;
            }
        }
    }

    return count;
}
