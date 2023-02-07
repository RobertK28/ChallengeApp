
namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void WhenEmployee1CollectPoint_ShouldReturnSumOfPoints()
        {
            //arrange
            var employee1 = new Employee("Tom", "Cruise", 25);
            employee1.AddPointsOfEmployee(5);
            employee1.AddPointsOfEmployee(2);
            employee1.AddPointsOfEmployee(3);
            employee1.AddNegativePointsOfEmployee(5);
            
            //act
            var ratingEmployee1 = employee1.PointsOfEmployee;

            //assert
            Assert.AreEqual(5, ratingEmployee1);

        }

        [Test]
        public void WhenEmployee2CollectPoint_ShouldReturnSumOfPoints()
        { 
            //arrange
            var employee2 = new Employee("Brad", "Pitt", 32);
            employee2.AddPointsOfEmployee(3);
            employee2.AddNegativePointsOfEmployee(2);
            employee2.AddPointsOfEmployee(7);
            
            //act
            var ratingEmployee2 = employee2.PointsOfEmployee;

            //assert
            Assert.AreEqual(8, ratingEmployee2);

        }




    }
}
