public class Solution {
    public int Tribonacci(int n) {
        if (n == 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 1;

        var twoPrevious = 0;
        var previous = 1;
        var current = 1;

        for (var i = 3; i <= n; i++) {
            var next = current + previous + twoPrevious;

            twoPrevious = previous;
            previous = current;
            current = next;
        }

        return current;
    }
}