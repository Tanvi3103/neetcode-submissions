public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var map = new Dictionary<char, int>();

        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            if (map.ContainsKey(c) && map[c] >= left)
            {
                left = map[c] + 1;
            }

            map[c] = right;

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
