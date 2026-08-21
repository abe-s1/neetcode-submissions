public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var rightMax = arr[^1];
        arr[^1] = -1;

        for (int i = arr.Length - 2; i >= 0; i--) {
            var current = arr[i];
            arr[i] = rightMax;
            rightMax = Math.Max(current, rightMax);
        }

        return arr;
    }
}