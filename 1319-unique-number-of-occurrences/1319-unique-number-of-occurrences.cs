public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        HashSet<int> UniqueNumInArray = new HashSet<int>(arr);
        List<int> NumberOfRepeat = new List<int>();
        int counter;
        foreach (int item in UniqueNumInArray)
        {
            counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                    counter++;
            }

            if (NumberOfRepeat.Contains(counter))
                return false;
            else
                NumberOfRepeat.Add(counter);

        }

            return true;
    }
}