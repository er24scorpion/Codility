
Console.WriteLine(Solution.GetSolution(new[] { 2, 3, 1, 5, 4 }));
Console.WriteLine(Solution.GetSolution(new[] { 4, 1, 3 }));

static class Solution
{
    public static int GetSolution(int[] A)
    {
        if (A.Length == 1) return A[0] == 1 ? 1 : 0;

        Array.Sort(A);
        var isPerm = 1;
        var index = 0;
        for (var i = 1; i <= A.Length; i++, index++)
        {
            if (A[index] != i) return 0;
        }
        return isPerm;
    }
}