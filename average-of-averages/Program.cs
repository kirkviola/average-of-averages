Console.WriteLine("sup!");
var numberList = new List<double>()
{
    4, 2, 64, 4.7, 42, 532, 2.31, 30532
};
var result = MatchingAverages(numberList) ? "They match! Incredible!" : "They don't match dummy"; 
Console.WriteLine(result);

bool MatchingAverages(List<double> nums)
{
    if (nums == null)
        return false;
    var newListOne = new List<double>();
    var newListTwo = new List<double>();

    var totalAvg = nums.Average();

    for(int i = 0; i < nums.Count / 2; i++)
    {
        newListOne.Add(nums[i]);
    }
    for(int i = nums.Count / 2; i < nums.Count; i++)
    {
        newListTwo.Add(nums[i]);
    }

    var newAverages = new List<double>()
    {
        newListOne.Average(), newListTwo.Average()
    };

    return newAverages.Average() == totalAvg;
}