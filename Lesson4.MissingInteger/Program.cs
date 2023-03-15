using System.Diagnostics;

var A = new int[100000];
var random = new Random();
var upTo = 90000;
for (var i = 0; i < upTo; i++)
{
    A[i] = i;
}
for (var i = upTo; i < A.Length; i++)
{
    A[i] = random.Next(1, 100000);
}
var B = new int[A.Length];
Array.Copy(A, B, A.Length);
Array.Sort(B);
Console.WriteLine(string.Join(",", B.Take(100)));
Console.WriteLine();

var s = new Stopwatch();
s.Start();
var sol = Solution.GetSolution(A);
s.Stop();
Console.WriteLine($"Answer is {sol}. Solution  took {s.ElapsedMilliseconds}ms");

//var C = new[] { 1, 2, 3 };
//var sol2 = Solution.GetSolution(C);
//Console.WriteLine($"Answer is {sol2}");

static class Solution
{
    public static int GetSolution(int[] A)
    {
        var sortedSet = Enumerable.Range(1, A.Length);

        var intersect = sortedSet.Except(A);
        if (!intersect.Any())
        {
            var max = A.Max();
            return max <= 0 ? 1 : max + 1;
        }
        return intersect.Min();

    }
}