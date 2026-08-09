public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right) {
            var sum = numbers[left] + numbers[right];

            if (sum == target)
                return [left + 1, right + 1];
            else if (sum < target)
                left++;
            else
                right--;
        }

        return [-1, -1];  // no solution found (impossible according to description)
    }
}

// Why this works:
// When we start tracking the left and right numbers, those numbers are both
// the smallest and largest numbers possible.
// Thus, if their sum is greater than the target, we know for certain that the 
// right number (the max) is not in the solution, because even when combining it
// with the smallest number, it's still too large.
// We can therefore eliminate it.
// The same logic applies (just in reverse) for if the sum is too little - that means
// the left number can not be in the solution as it is the min and even combined with
// the largest number, is not enough to reach the target.