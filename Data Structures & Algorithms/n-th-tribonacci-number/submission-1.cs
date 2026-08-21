public class Solution {
    private int[] _lastThreeValues = [0, 1, 1];

    public int Tribonacci(int n) {
        if (n < 3) return _lastThreeValues[n];  // todo just do if-branching...?

        for (var i = 3; i <= n; i++) {
            var next = _lastThreeValues[0] + _lastThreeValues[1] + _lastThreeValues[2];

            _lastThreeValues[0] = _lastThreeValues[1];
            _lastThreeValues[1] = _lastThreeValues[2];
            _lastThreeValues[2] = next;
        }

        return _lastThreeValues[2];
    }
}