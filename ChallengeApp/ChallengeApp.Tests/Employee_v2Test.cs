
namespace ChallengeApp.Tests
{
    public class Employee_v2Test
    {
        [Test]
        public void WhenSumOfGradesIs10_ThenAverageHave3InPeriod()
        {
            //arrange
            var employee1 = new Employee_v2("Tomasz", "Kot");
            employee1.AddGrade(5);
            employee1.AddGrade(3);
            employee1.AddGrade(2);


            //act
            var statisticsEmployee1 = employee1.GetStatistics();
            var AverageGradeOfEmployee1 = statisticsEmployee1.Average;

            //assert
            Assert.AreEqual(Math.Round(3.33,2), Math.Round(AverageGradeOfEmployee1,2));

        }
        
        [Test]
        public void WhenEmployyeHaveGradefrom2to5_ThenMaxGradeIs5()
        {
            //arrange
            var employee1 = new Employee_v2("Tomasz", "Kot");
            employee1.AddGrade(5);
            employee1.AddGrade(3);
            employee1.AddGrade(2);
            var statisticsOfEmployee1 = employee1.GetStatistics();
            
            //act
            var MaxGradeOfEmployee = statisticsOfEmployee1.Max;

            //assert
            Assert.AreEqual(5, MaxGradeOfEmployee);        
        
        }
        
        [Test]
        public void WWhenEmployyeHaveGradefrom2to5_ThenMinGradeIs2()
        {
            //arrange
            var employee1 = new Employee_v2("Tomsza", "Kot");
            employee1.AddGrade(5);
            employee1.AddGrade(3);
            employee1.AddGrade(2);
            var statisticsOfEmployee1 = employee1.GetStatistics();

            //act
            var MinGradeOfEmployee = statisticsOfEmployee1.Min;

            //assert
            Assert.AreEqual(2, MinGradeOfEmployee);
          
        }

        [Test]
        public void WhenStatisticAverageisbetween80and100_ThenStatisticAverageLetterisA()
        {
            //arrange
            var employee2 = new Employee_v2();
            employee2.AddGrade(81);
            employee2.AddGrade(92);
            employee2.AddGrade(85);
            var statisticsOfEmployee2 = employee2.GetStatistics();

            //act
            var AverageLetterOfEmployee2 = statisticsOfEmployee2.AverageLetter;
            

            //assert
            Assert.AreEqual('A', AverageLetterOfEmployee2);
                   
        }

        [Test]
        public void WhenGradeisCOrc_ThenThisGradeAdd60()
        { 
            //arrange
            var employee3 = new Employee_v2();
            employee3.AddGrade('C');

            //act
            var thisGrade = employee3.grades[0];

            //assert
            Assert.AreEqual(60, thisGrade);

        }

    }
}
