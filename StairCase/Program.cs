// Staircase detail
// This is a staircase of size 4
//
//    #
//   ##
//  ###
// ####

staircase(8);


static void staircase(int n)
{
    for (var i = 1; i <= n; i++)
    {
        for (var y = 0; y < n - i; y++)
        {
            Console.Write(" ");
        }

        for (var z = 0; z < i; z++)
        {
            Console.Write("#");
        }

        Console.WriteLine();
    }
}