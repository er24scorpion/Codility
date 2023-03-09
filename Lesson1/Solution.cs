// See https://aka.ms/new-console-template for more information

public static class Solution { 
    public static int GetSolution(int N)
    {
        var binary = Convert.ToString(N, 2);
        var digitals = binary.ToCharArray();

        var maxBinaryGap = 0;
        var currentGap = 0;

        if (digitals[0] == '1' && binary.IndexOf("0")>-1)
        {
            for (var i = 1; i < digitals.Length; i++)
            {
                var digit = digitals[i];
                if (digit == '1')
                {
                    maxBinaryGap = maxBinaryGap < currentGap ? currentGap : maxBinaryGap;
                    currentGap = 0;
                }
                else
                {
                    currentGap++;
                }

            }
        }
        return maxBinaryGap;
    }

    public static int GetSolution2(int N)
    {
        var binary = Convert.ToString(N, 2);
        if (binary.Length < 3) return 0;

        var withoutFitstLastOne = binary.Substring(binary.IndexOf('1')+1, binary.LastIndexOf('1'));

        
        var zeros = withoutFitstLastOne.Split('1', options: StringSplitOptions.RemoveEmptyEntries);

        return zeros.Any() ? zeros.Max(x => x.Length) : 0;
    }
}