using System.Diagnostics;
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
        //

        
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

        public Statistics GetStatisticsForeach()
        {
            var statisticsForeach = new Statistics();
            statisticsForeach.Average = 0;
            statisticsForeach.Max = float.MinValue;
            statisticsForeach.Min = float.MaxValue;


            foreach (var grade in this.grades)
            {

                statisticsForeach.Max = Math.Max(statisticsForeach.Max, grade);
                statisticsForeach.Min = Math.Min(statisticsForeach.Min, grade);
                statisticsForeach.Average += grade;

            }

            statisticsForeach.Average /= this.grades.Count;
            return statisticsForeach;

        }

        public Statistics GetStatisticsFor()
        { 
            var statisticsFor = new Statistics();
            statisticsFor.Average = 0;
            statisticsFor.Max = float.MinValue;
            statisticsFor.Min = float.MaxValue;
            

            for (var index = 0; index < this.grades.Count; index++)
            {
                statisticsFor.Max = Math.Max(statisticsFor.Max, this.grades[index]);
                statisticsFor.Min = Math.Min(statisticsFor.Min, this.grades[index]);
                statisticsFor.Average += this.grades[index];
            }
            statisticsFor.Average /= (float) this.grades.Count;
            return statisticsFor;
        
        }


        public Statistics GetStatisticsdDoWhile()
        {
            var statisticsDoWhile = new Statistics();
            statisticsDoWhile.Average = 0;
            statisticsDoWhile.Max = float.MinValue;
            statisticsDoWhile.Min = float.MaxValue;
            var index = 0;

            do
            {
                statisticsDoWhile.Max = Math.Max(statisticsDoWhile.Max, this.grades[index]);
                statisticsDoWhile.Min = Math.Min(statisticsDoWhile.Min, this.grades[index]);
                statisticsDoWhile.Average += this.grades[index];
                index++;
            }while(index < this.grades.Count);

            statisticsDoWhile.Average /= this.grades.Count;
            return statisticsDoWhile;

        }

        public Statistics GetStatisticsWhile()
        {
            var statisticsWhile = new Statistics();
            statisticsWhile.Average = 0;
            statisticsWhile.Max = float.MinValue;
            statisticsWhile.Min = float.MaxValue;
            var index = 0;

            while (index < this.grades.Count)
            {
                if (this.grades[index] == 5)
                {
                    break;
                }
                statisticsWhile.Max = Math.Max(statisticsWhile.Max, this.grades[index]);
                statisticsWhile.Min = Math.Min(statisticsWhile.Min, this.grades[index]);
                statisticsWhile.Average += this.grades[index];
                index++;
            }

            statisticsWhile.Average /= this.grades.Count;
            return statisticsWhile;

        }
    }
}
