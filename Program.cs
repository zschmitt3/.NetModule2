﻿Console.WriteLine("Enter 1 to create data file.");
Console.WriteLine("Enter 2 to parse data.");
Console.WriteLine("Enter anything else to quit.");
// input response
string? resp = Console.ReadLine();

if (resp == "1")
{

    Console.WriteLine("How many weeks of data is needed?");
    // input the response (convert to int)
    int weeks = int.Parse(Console.ReadLine());
}
else if (resp == "2")
{
    // TODO: parse data file

}
