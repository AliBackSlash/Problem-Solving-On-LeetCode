public class Solution {
    public int EqualPairs(int[][] grid) {
        
                int n = grid.Length;
                var rowCount = new Dictionary<string, int>();
                int count = 0;

                // ✅ تخزين كل صف كمفتاح في القاموس مع عدد مرات ظهوره
                foreach (var row in grid)
                {
                    string key = string.Join(",", row);
                    if (rowCount.ContainsKey(key))
                        rowCount[key]++;
                    else
                        rowCount[key] = 1;
                }

                // ✅ التحقق من الأعمدة ومقارنتها بالصفوف في القاموس
                for (int col = 0; col < n; col++)
                {
                    int[] colArr = new int[n];
                    for (int row = 0; row < n; row++)
                        colArr[row] = grid[row][col];

                    string key = string.Join(",", colArr);

                    if (rowCount.ContainsKey(key))
                        count += rowCount[key]; // إضافة عدد التكرارات
                }

                return count;
    }
}