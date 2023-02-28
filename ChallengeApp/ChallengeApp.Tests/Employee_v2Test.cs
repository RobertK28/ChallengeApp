
namespace ChallengeApp.Tests
{
    public class Employee_v2Test
    {
        [Test]
        public void WhenSumOfGradesIs10_ThenAverageHave3InPeriod()
        {
            //arrange
            var employee1 = new Employee_v2("Tomasz", "Kot");
            employee1.AdGrade(5);
            employee1.AdGrade(3);
            employee1.AdGrade(2);


            //act
            var statisticsEmployee1 = employee1.GetStatistics();
            var AverageGradeOfEmployee1 = statisticsEmployee1.Average;

            //assert
            Assert.AreEqual(Math.Round(3.33,2), Math.Round(AverageGradeOfEmployee1,2);

        }

        [Test]
        public void WhenEmployyeHaveGradefrom2to5_ThenMaxGradeIs5()
        {
            //arrange
            var employee1 = new Employee_v2("Tomasz", "Kot");
            employee1.AdGrade(5);
            employee1.AdGrade(3);
            employee1.AdGrade(2);
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
            employee1.AdGrade(5);
            employee1.AdGrade(3);
            employee1.AdGrade(2);
            var statisticsOfEmployee1 = employee1.GetStatistics();

            //act
            var MinGradeOfEmployee = statisticsOfEmployee1.Min;

            //assert
            Assert.AreEqual(2, MinGradeOfEmployee);
        
        
        
        }



    }
}
