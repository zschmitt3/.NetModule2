Console.WriteLine("Enter 1 to create data file.");
Console.WriteLine("Enter 2 to parse data.");
Console.WriteLine("Enter anything else to quit.");
string? resp = Console.ReadLine();

if (resp == "1")
{

    Console.WriteLine("How many weeks of data is needed?");
    int weeks = int.Parse(Console.ReadLine());
    
    DateTime today = DateTime.Now;
    DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
    DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));
    
    Random rnd = new Random();
    StreamWriter sw = new StreamWriter("data.txt");


    while (dataDate < dataEndDate)
    {
        int[] hours = new int[7];
        for (int i = 0; i < hours.Length; i++)
        {
            hours[i] = rnd.Next(4, 13);
        }
        sw.WriteLine($"{dataDate:M/d/yyyy},{string.Join("|", hours)}");
        dataDate = dataDate.AddDays(7);
    }
    sw.Close();
}
else if (resp == "2")
{
    StreamReader sr = new StreamReader("data.txt");
    DateTime weekOf;
    string weekOfString;
    string dataLine = sr.ReadLine();

    while (dataLine != null){
        weekOfString = dataLine.Substring(0,dataLine.IndexOf(","));
        weekOf = DateTime.Parse(weekOfString);
        dataLine = dataLine.Substring(weekOfString.Length);
        Console.WriteLine("Week of {0:MMM}, {0:dd}, {0:yyyy}", weekOf);
        Console.WriteLine(" Su Mo Tu We Th Fr Sa");
        Console.WriteLine(" -- -- -- -- -- -- --");


        dataLine = sr.ReadLine();
    }

}
