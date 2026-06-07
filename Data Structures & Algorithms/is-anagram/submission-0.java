class Solution {
    public boolean isAnagram(String s, String t) {

        if (s.length() != t.length()) {
            return false;
        }
        Map<Character, Integer> map = new HashMap();
        for(char c : s.toCharArray()){
            if(map.containsKey(c)){
                int freq = map.get(c);
                freq++;
                map.put(c,freq);
            }
            else{
                map.put(c,1);
            }
        }

        for(char c : t.toCharArray()){
            if(map.containsKey(c)){
                int freq = map.get(c);
                freq--;
                if(freq==0)
                    map.remove(c);
                else
                map.put(c,freq);
            }
            else
                return false;

        }
        return map.size() == 0;
    }
}