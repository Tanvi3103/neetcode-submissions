public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        // Dictionary to store:
        // Number -> Frequency
        Dictionary<int, int> freq =
            new Dictionary<int, int>();


        // Count frequency of each number
        foreach (int num in nums)
        {
            // First occurrence
            if (!freq.ContainsKey(num))
                freq[num] = 0;

            // Increment count
            freq[num]++;
        }


        // Min Heap
        // Element  = number
        // Priority = frequency
        //
        // Smallest frequency stays at the top
        PriorityQueue<int, int> pq =
            new PriorityQueue<int, int>();


        // Traverse frequency map
        foreach (var pair in freq)
        {
            // Extract number
            int number = pair.Key;

            // Extract frequency
            int count = pair.Value;

            // Insert into heap
            //
            // Example:
            // Enqueue(1,3)
            // Number = 1
            // Frequency = 3
            pq.Enqueue(number, count);

            // If heap size exceeds k
            if (pq.Count > k)
            {
                // Remove least frequent element
                pq.Dequeue();
            }
        }


        // Result array to store answer
        int[] result = new int[k];


        // Extract remaining top k elements
        //
        // Going backwards because
        // heap returns smaller frequencies first
        for (int i = k - 1; i >= 0; i--)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}