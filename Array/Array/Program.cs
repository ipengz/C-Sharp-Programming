

String[] myStringArray = ["Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun"];

Console.WriteLine("Length of array is " + myStringArray.Length);

foreach (string str in myStringArray)
{
    Console.WriteLine(str);
}

// Create a tic tac toe array
String[,] my3StringArray =
{
    {"X","O","X" },
    {"O","O","X" },
    {"X","O","O" }
};

Console.WriteLine(my3StringArray[1,2]);

// Create 3D Array
String[,,] simple3DArray =
{
    {
        {"000","001" },
        {"010","011" }
    },
    {
        {"100","101" },
        {"110","111" }
    },
    {
        {"200","201" },
        {"210","211" }
    }
};

Console.WriteLine(simple3DArray[2,0,1]);

int[] arrayNumber = [1, 2, 3, 4, 5];

foreach (int count in arrayNumber)
{
    Console.WriteLine(count);
}

Console.ReadKey();
