//Students get grades from 0 to 100
// Any grade less than 40 is failing

// If difference between the grade and the next multiple of 5 is less than 3, round that grade up to the next multiple of 5
//Example grade 84 = round to 85 (85 - 84 is less than 3)
//Grade 29 - fail (less than 40)
//Grade 57 - do not round (60 - 57 = 3, have to be less than 3 to round up)

var grade = new List<int>() { 73, 67, 38, 33 };
grade = gradingStudents(grade);

foreach (var g in grade)
{
    Console.WriteLine(g);
}

static List<int> gradingStudents(List<int> grades)
{
    var result = new List<int>();
    foreach (var g in grades)
    {
        
        if (g >= 38 && g % 5 != 0)
        {
            var closest = (g - (g % 5) + 5);
            var diff = closest - g;
            if (diff < 3 && closest > g)
            {
                result.Add(closest);
                continue;
            }
        }
        
        result.Add(g);
    }

    return result;
}
