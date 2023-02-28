using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ChallengeApp
{
    public class Employee_v2
    {
        List<float> grades = new List<float>();
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
