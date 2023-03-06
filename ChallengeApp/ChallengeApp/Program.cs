using ChallengeApp;
using System.Runtime.CompilerServices;

Console.WriteLine("Program XYZ do oceny pracowników");
Console.WriteLine("================================");
Console.WriteLine();

var employee = new Employee_v2();

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q") 
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
