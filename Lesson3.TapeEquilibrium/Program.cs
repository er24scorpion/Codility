
Console.WriteLine(Solution.GetSolution(new[] { 3, 1, 2, 4, 3 }));

static class Solution
{
    public static int GetSolution(int[] A)
    {
        var diffs = new int[A.Length-1];
        var total = A.Sum();
        var sum = 0;
        for (var i = 0; i < A.Length-1; i++)
        {
            sum += A[i];
            total -= A[i];
            diffs[i] = Math.Abs(sum - total);
        }
        return diffs.Min();
    }
}