using ChallengeApp;
using System.Runtime.CompilerServices;

/*
Employee employee1 = new Employee("Tom", "Cruise", 25);
Employee employee2 = new Employee("Brad", "Pitt", 32);
Employee employee3 = new Employee("Tomasz", "Kot", 28);

// Points of Employee1
employee1.AddPointsOfEmployee(1);
employee1.AddPointsOfEmployee(3);
employee1.AddPointsOfEmployee(5);
employee1.AddNegativePointsOfEmployee(6);
employee1.AddPointsOfEmployee(4);

// Points of Employee2
employee2.AddPointsOfEmployee(3);
employee2.AddPointsOfEmployee(2);
employee2.AddPointsOfEmployee(5);
employee2.AddPointsOfEmployee(7);
employee2.AddPointsOfEmployee(4);

// Points of Employee3
employee3.AddPointsOfEmployee(4);
employee3.AddPointsOfEmployee(7);
employee3.AddPointsOfEmployee(5);
employee3.AddPointsOfEmployee(6);
employee3.AddPointsOfEmployee(8);

var ratingEmployee1 = employee1.PointsOfEmployee;
var ratingEmployee2 = employee2.PointsOfEmployee;
var ratingEmployee3 = employee3.PointsOfEmployee;

List<int> ratingListOfEmployee = new List<int> 
{ ratingEmployee1, ratingEmployee2, ratingEmployee3 };

int maxRating = -1;
Employee employeeWithMaxRating = null;
int indexOfratingListOfEmployee = -1;
Employee ratingEmployeeEach = null;

foreach (var ratingEmployee in ratingListOfEmployee)
{ 
    if (ratingEmployee > maxRating)
    {
        maxRating = ratingEmployee;
        indexOfratingListOfEmployee = ratingListOfEmployee.IndexOf(ratingEmployee);

        if (indexOfratingListOfEmployee == 0)
        {
            employeeWithMaxRating = employee1;
            ratingEmployeeEach = employee1;
        }
        else if (indexOfratingListOfEmployee == 1)
        {
            employeeWithMaxRating = employee2;
            ratingEmployeeEach = employee2;
        }
        else if (indexOfratingListOfEmployee == 2)
        { 
            employeeWithMaxRating = employee3;
            ratingEmployeeEach = employee3;
        }
    }
    Console.WriteLine($"{ratingEmployeeEach.DataOfEmployee} -zdobył {maxRating} punktów.");
    
}
Console.WriteLine("\n");

Console.WriteLine($"Największą liczbę ocen zdobył/a {employeeWithMaxRating.DataOfEmployee} z wynikiem : { maxRating }  punktów.");

*/

var employee1 = new Employee_v2("Tomasz", "Kot");
employee1.AdGrade("TOm");
employee1.AdGrade("4000");
employee1.AdGrade(2.34d);
employee1.AdGrade(2);
employee1.AdGrade(3);
var statistics = employee1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
var statisticsForeach = employee1.GetStatisticsForeach();
Console.WriteLine($"AverageForeach: {statisticsForeach.Average:N2}");
Console.WriteLine($"MaxForeach: {statisticsForeach.Max}");
Console.WriteLine($"MinForeach: {statisticsForeach.Min}");
var statisticsFor = employee1.GetStatisticsFor();
Console.WriteLine($"AverageFor: {statisticsFor.Average:N2}");
Console.WriteLine($"MaxFor: {statisticsFor.Max}");
Console.WriteLine($"MinFor: {statisticsFor.Min}");
var statisticsDoWhile = employee1.GetStatisticsdDoWhile();
Console.WriteLine($"AverageDoWhile: {statisticsDoWhile.Average:N2}");
Console.WriteLine($"MaxDoWhile: {statisticsDoWhile.Max}");
Console.WriteLine($"MinDoWhile: {statisticsDoWhile.Min}");
var statisticsWhile = employee1.GetStatisticsWhile();
Console.WriteLine($"AverageWhile: {statisticsWhile.Average:N2}");
Console.WriteLine($"MaxWhile: {statisticsWhile.Max}");
Console.WriteLine($"MinWhile: {statisticsWhile.Min}");


/*SetSth(ref statistics);
void SetSth(ref Statistics statistics)
{
    statistics = new Statistics();
}
*/
//