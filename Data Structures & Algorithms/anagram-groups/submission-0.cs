public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map =
            new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            int[] freq = new int[26];

            foreach (char c in word)
            {
                freq[c - 'a']++;
            }

            string key = string.Join("#", freq);

            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }

            map[key].Add(word);
        }

        return map.Values
                  .Select(x => (List<string>)x)
                  .ToList();
    }
}
