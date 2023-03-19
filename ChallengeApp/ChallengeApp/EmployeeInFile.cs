using ChallengeApp;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }


        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                switch (charResult)
                {
                    case 'A' or 'a':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(100);
                        }
                        break;
                    case 'B' or 'b':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(80);
                        }
                        break;
                    case 'C' or 'c':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(60);
                        }
                        break;
                    case 'D' or 'd':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(40);
                        }
                        break;
                    case 'E' or 'e':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(20);
                        }
                        break;
                    default:
                        throw new Exception("Wrong Letter");
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }


        public override void AddGrade(double grade)
        {
            float gradeInFloat = (float)grade;
            this.AddGrade(gradeInFloat);
        }

        public override void AddGrade(long grade)
        {
            float gradeInFloat = (float)grade;
            this.AddGrade(gradeInFloat);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(100);
                    }
                    break;
                case 'B' or 'b':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(80);
                    }
                    break;
                case 'C' or 'c':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(60);
                    }
                    break;
                case 'D' or 'd':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(40);
                    }
                    break;
                case 'E' or 'e':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(20);
                    }
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        { 
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    { 
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    } 
                }
            }
            return grades;
        
        }

        private Statistics CountStatistics(List<float> grades)
        { 
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades) 
            {
                if (grade >= 0)
                { 
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;                
                }            
            }
            
            statistics.Average /= grades.Count;

            switch (statistics.Average)
            { 
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default: 
                    statistics.Average = 'E'; 
                    break;
            }

            return statistics;
        
        }
    }
}
