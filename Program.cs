using LeetcodeProblems.TwoSum;

var testParams = new []{-3, 4, 3, 90};
const int target = 0;

var t = new TwoSumSolution().TwoSumV2(testParams, target);

foreach (var i in t)
{
    Console.WriteLine(i);
}