/*
 * 
 */

string? res = string.Empty;
var test = new[] { 1, 2, 4, 9, 529, 20, 15, 32, 1041, 32 };

foreach (var i in test)
{
    Console.WriteLine($"The number is {i}, binary code is {Convert.ToString(i, 2)}");
    Console.WriteLine($"Solution 1: {Solution.GetSolution(i)}");
    Console.WriteLine($"Solution 2: {Solution.GetSolution2(i)}");
    Console.WriteLine();
}

