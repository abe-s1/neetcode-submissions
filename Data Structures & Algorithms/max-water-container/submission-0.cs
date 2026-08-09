public class Solution {
    public int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length - 1;
        var max = 0;

        while (left < right) {
            var current = Math.Min(heights[left], heights[right]) * (right - left);
            max = Math.Max(max, current);

            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }

        return max;
    }
}
