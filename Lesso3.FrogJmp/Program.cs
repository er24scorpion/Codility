
Console.WriteLine(Solution.GetSolutiion(10, 85, 30));

static class Solution
{

    public static int GetSolutiion(int X, int Y, int D)
    {
        if (X >= Y) return 0;

        return (int) Math.Ceiling((decimal)(Y - X) / D);
    }
}