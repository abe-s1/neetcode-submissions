public class Solution {
    public int LongestConsecutive(int[] nums) {
        var unique = nums.ToHashSet();

        var max = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (unique.Contains(nums[i] - 1)) continue;  // not the start of a sequence

            var length = GetSequenceLength(nums[i], unique);

            max = Math.Max(max, length);
        }

        return max;
    }

    private int GetSequenceLength(int start, HashSet<int> unique) {
        var length = 1;
        var next = start + 1;

        while (unique.Contains(next)) {
            length++;
            next++;
        }

        return length;
    }
}
