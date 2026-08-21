public class Solution {
    private List<int> _cache = [0, 1, 1];

    public int Tribonacci(int n) {
        if (_cache.Count > n)
            return _cache[n];

        var value = Tribonacci(n-1) + Tribonacci(n-2) + Tribonacci(n-3);
        _cache.Add(value);

        return _cache[n];
    }
}