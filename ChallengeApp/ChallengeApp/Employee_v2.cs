using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ChallengeApp
{
    public class Employee_v2
    {
        public List<float> grades = new List<float>();
        public Employee_v2(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public void AdGrade(float grade) 
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }   
            
        }
        public void AdGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AdGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
         public void AdGrade(double grade)
         {
            float gradeInFloat = (float)grade;
            this.AdGrade(gradeInFloat);
         }

        public void AdGrade(long grade) 
        {
            float gradeInFloat = (float)grade;
            this.AdGrade(gradeInFloat);
        }

        public void AddGrade(char grade)
        {
            /*
            if (grade == 'A' || grade == 'a')
            {
                this.grades.Add(100);
            }
            else if (grade == 'B' || grade == 'b')
            {
                this.grades.Add(80);
            }
            else if (grade == 'C' || grade == 'c')
            {
                this.grades.Add(60);
            }
            else if (grade == 'D' || grade == 'd')
            {
                this.grades.Add(40);
            }
            else if (grade == 'E' || grade == 'e')
            {
                this.grades.Add(20);
            }
            else
            {
                Console.WriteLine("zła litera");
            }
            */

            switch (grade) 
            { 
                case 'A':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
            }

        }

        
        public Statistics GetStatistics()
        { 
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            
            foreach (var grade in this.grades) 
            {
                               
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
                            
            }
        
            statistics.Average /= this.grades.Count;
            return statistics;
        
        }


    }
}
