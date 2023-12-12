namespace spiral_matrix_ii
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var sol = new Solution();
           var ans = sol.GenerateMatrix(3);

        }
    }

    public class Solution
    {
        public int[][] GenerateMatrix(int n)
        {
            var ans = new int[n][];
            for(int i = 0; i < n; i++)
            {
                ans[i] = new int[n];
            }
            int no = 1;
            int rowStart = 0, colStart = 0, rowEnd = n - 1, colEnd = n - 1;
            while (no <= n * n)
            {

                for (int j = colStart; j <= colEnd; j++)
                {
                    ans[rowStart][j] = no++;
                }
                rowStart++;
                for (int i = rowStart; i <= rowEnd; i++)
                {
                    ans[i][colEnd] = no++;
                }
                colEnd--;
                for (int j = colEnd; j >= colStart; j--)
                {
                    ans[rowEnd][j] = no++;
                }
                rowEnd--;
                for (int i = rowEnd; i >= rowStart; i--)
                {
                    ans[i][colStart] = no++;
                }
                colStart++;
            }

            return ans.Select(i => i.ToArray()).ToArray();
        }
    }
}
