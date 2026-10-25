public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var frequencies = new int[26];
        var max = 0;

        for (int left = 0, right = 0; right < s.Length; right++)
        {
            var letter = s[right] - 65;
            frequencies[letter]++;

            var length = (right - left + 1);
            var isValid = length - GetMostFrequent(frequencies) <= k;

            while (!isValid)
            {
                letter = s[left] - 65;
                frequencies[letter]--;
                left++;
                length = (right - left + 1);
                isValid = length - GetMostFrequent(frequencies) <= k;
            }
            
            max = Math.Max(max, length);
        }

        return max;
    }

    private int GetMostFrequent(int[] frequencies)
    {
        return frequencies.Aggregate((a, b) => Math.Max(a, b));
    }
}