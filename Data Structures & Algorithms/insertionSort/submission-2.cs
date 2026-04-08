// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;

//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }

public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        if (pairs == null) return null;

        List<List<Pair>> output = new();
        if (pairs.Count == 0) return output;
        
        output.Add(pairs);

        int j;
        for (int i = 0; i < pairs.Count - 1; i++)
        {
            j = i + 1;
            pairs = pairs.Select(pair => new Pair(pair.Key, pair.Value)).ToList();
            while (j > 0 && pairs[j].Key < pairs[j - 1].Key)
            {
                var temp = pairs[j - 1];
                pairs[j - 1] = pairs[j];
                pairs[j] = temp;
                --j;
            }
            output.Add(pairs);
        }
        return output;
    }
}
