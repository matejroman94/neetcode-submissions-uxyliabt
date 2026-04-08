// public class Pair {
//     public int Key;
//     public string Value; 

//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> QuickSort(List<Pair> pairs)
    {
        if (pairs.Count <= 1) return pairs;

        Perform(pairs, 0, pairs.Count-1);

        return pairs;
    }

    private void Perform(List<Pair> pairs, int low, int high)
    {
        if (low >= high)
        {
            return;
        }

        int pivot = high;
        int i = low - 1;
        int j = low;

        while (j < pivot)
        {
            if (pairs[j].Key < pairs[pivot].Key)
            {
                Swapp(pairs, ++i, j);
            }
            ++j;
        }

        Swapp(pairs, ++i, pivot);
        pivot = i;

        Perform(pairs,low,pivot-1);
        Perform(pairs,pivot+1,high);
    }

    private void Swapp(List<Pair> pairs, int i, int j)
    {
        (pairs[i], pairs[j]) = (pairs[j], pairs[i]);
    }
}
