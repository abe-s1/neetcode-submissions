public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var results = new List<List<int>>();
        
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            results.AddRange(
                TwoSum(nums, 
                    target: -nums[i], 
                    left: i + 1, 
                    right: nums.Length - 1)
            );
        }
        
        return results;
    }

    
    private List<List<int>> TwoSum(int[] nums, int target, int left, int right) {
        var results = new List<List<int>>();

        while (left < right) {
            if (nums[left] + nums[right] == target) {
                results.Add([-target, nums[left], nums[right]]);

                do {
                    left++;
                } while (left < right && nums[left] == nums[left - 1]);

                do {
                    right--;
                } while (left < right && nums[right] == nums[right + 1]);

                continue;
            }

            if (nums[left] + nums[right] < target)
                left++;
            else if (nums[left] + nums[right] > target)
                right--;
        }

        return results;
    }
}
