using ChallengeApp;
using System.Runtime.CompilerServices;

Console.WriteLine("Program XYZ do oceny pracowników");
Console.WriteLine("================================");
Console.WriteLine();
Console.WriteLine(" Wybierz stanowisko ocenianej kadry wpisując słowo: ");
Console.WriteLine();
Console.WriteLine(" Kierownik ");
Console.WriteLine(" Pracownik ");
Console.WriteLine();
Console.WriteLine(" Koniec procesu oceny ->  wpisz: q");
Console.WriteLine();
Console.WriteLine(" Zasady Oceny:");
Console.WriteLine();
Console.WriteLine(" Kierownik: Należy wpisać cyfrę od 1 do 6 lub literę zgodnie z poniższym:");
Console.WriteLine(" Do cyfr od 1 do 6 można dodać znak + który doda 5 pkt lub znak - który odejmie 5 pkt.");
Console.WriteLine();
Console.WriteLine(" 6 lub A lub a = > 100 pkt.");
Console.WriteLine(" 5 lub B lub b = > 80 pkt.");
Console.WriteLine(" 4 lub C lub c = > 60 pkt.");
Console.WriteLine(" 3 lub D lub d = > 40 pkt.");
Console.WriteLine(" 2 lub E lub e = > 20 pkt.");
Console.WriteLine(" 1 lub F lub f = > 0 pkt.");
Console.WriteLine();
Console.WriteLine(" Pracownik: Można dodać dowolną ilość pkt w zakresie od 0 do 100");
Console.WriteLine(" Lub wpisując literę, zgodnie z punktacją kadry kierowniczej"); 
Console.WriteLine();

var employee = new Employee_v2();
var supervisor = new Supervisor();

var inputWho = Console.ReadLine();

if (inputWho == "Kierownik")
{
    while (true)
    {
        Console.WriteLine("Podaj ocenę pracownika");
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
        try
        {
            supervisor.AddGrade(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception cathced: {ex.Message}");
        }
    }
    Console.WriteLine();
    var statisticsSupervisor = supervisor.GetStatistics();
    Console.WriteLine($"Average: {statisticsSupervisor.Average}");
    Console.WriteLine($"Min: {statisticsSupervisor.Min}");
    Console.WriteLine($"Max: {statisticsSupervisor.Max}");
    Console.WriteLine($"AverageLetter: {statisticsSupervisor.AverageLetter}");

}

else if (inputWho == "Pracownik")
{
    while (true)
    {
        Console.WriteLine("Podaj ocenę pracownika");
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
        try
        {
            employee.AddGrade(input);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception cathced: {ex.Message}");
        }
    }
    Console.WriteLine();
    var statisticsEmployee = employee.GetStatistics();
    Console.WriteLine($"Average: {statisticsEmployee.Average}");
    Console.WriteLine($"Min: {statisticsEmployee.Min}");
    Console.WriteLine($"Max: {statisticsEmployee.Max}");
    Console.WriteLine($"AverageLetter: {statisticsEmployee.AverageLetter}");
}


