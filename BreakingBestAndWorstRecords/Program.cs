

var scores = new List<int>() { 10,5,20,20,4,5,2,25,1};
breakingRecords(scores);

static List<int> breakingRecords(List<int> scores)
{
    if (scores.Count == 0)
        return new List<int>() { 0, 0 };
    
    var minRecordBreak = 0;
    var maxRecordBreak = 0;

    var currentMin = scores.First();
    var currentMax = scores.First();

    for (var i = 1; i < scores.Count; i++)
    {
        var value = scores.ElementAt(i);
        
        if (value < currentMin)
        {
            currentMin = value;
            minRecordBreak++;
        }

        if (value > currentMax)
        {
            currentMax = value;
            maxRecordBreak++;
        }
    }

    return new List<int>() { maxRecordBreak, minRecordBreak };
}