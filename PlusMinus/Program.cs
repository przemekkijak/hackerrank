// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
// Print the decimal value of each fraction on a new line with places after the decimal.

using System.Globalization;

var arr = new int[] { 1, 1, 0, -1, -1 };
plusMinus(arr.ToList());


static void plusMinus(List<int> arr)
{
    var total = arr.Count;
    decimal positiveCount = 0;
    decimal negativeCount = 0;
    decimal zeroCount = 0;

    foreach (var a in arr)
    {
        if (a == 0)
        {
            zeroCount++;
            continue;
        }

        if (a > 0)
        {
            positiveCount++;
            continue;
        }

        negativeCount++;
    }

    positiveCount = decimal.Round((positiveCount / total), 6, MidpointRounding.AwayFromZero);
    negativeCount = decimal.Round((negativeCount / total), 6, MidpointRounding.AwayFromZero);
    zeroCount = decimal.Round((zeroCount / total), 6, MidpointRounding.AwayFromZero);

    Console.WriteLine(positiveCount.ToString("N6", CultureInfo.InvariantCulture));
    Console.WriteLine(negativeCount.ToString("N6", CultureInfo.InvariantCulture));
    Console.WriteLine(zeroCount.ToString("N6", CultureInfo.InvariantCulture));
}