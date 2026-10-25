public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        var window = new HashSet<char>();
        var max = 0;

        for (int left = 0, right = 0; right < s.Length; right++)
        {
            var current = s[right];
            var isUnique = window.Add(current);

            if (isUnique)
            {
                max = Math.Max(max, right - left + 1);
                continue;
            }
            
            while (s[left] != current)
                window.Remove(s[left++]);

            left++;
        }

        return max;
    }
}
