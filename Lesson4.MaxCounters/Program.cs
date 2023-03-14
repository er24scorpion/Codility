
using System.Diagnostics;

var A = new int[1001];
for (var i = 0; i < A.Length; i++)
{
    A[i] = (new Random()).Next(1, 1000);
}
var N = (new Random()).Next(1, 1000);
Console.WriteLine(string.Join(",", A));
Console.WriteLine($"N is {N}");

var s = new Stopwatch();
s.Start();
var sol = Solution.GetSolution(N, A);
s.Stop();
Console.WriteLine($"Solution took {s.ElapsedMilliseconds}ms");

//var sol = Solution.GetSolution(5, new[] { 3, 4, 4, 6, 1, 4, 4});
//Console.WriteLine(string.Join(",", sol));
static class Solution
{
    public static int[] GetSolution(int N, int[] A)
    {
        var B = new int[N];

        var max = 0;
        var lastFill = 0;
        for (var K = 0; K < A.Length; K++)
        {
            var AK = A[K];
            if (AK >= 1 && AK <= N)
            {
                if (B[AK - 1] < lastFill) B[AK - 1] = lastFill;
                max = Math.Max(max, ++B[AK - 1]);

            } else if (AK == N + 1)
            {
                lastFill = max;
            }

            //Console.WriteLine($"Array {K}: {string.Join(",", B)}");
        }

        for (var i = 0; i < B.Length; i++)
        {
            if (B[i] < lastFill) B[i] = lastFill;
        }
        //Console.WriteLine($"Array {A.Length}: {string.Join(",", B)}");
        return B;
    }
}