public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            while (!char.IsLetterOrDigit(s[left]) && left < right)
                left++;
            
            while (!char.IsLetterOrDigit(s[right]) && right > left)
                right--;
            
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
