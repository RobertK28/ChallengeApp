
namespace ChallengeApp.Tests
{
    public class UserTest
    {
        [Test]
        public void WhenUserCollectScors_ShouldReturnSumOfScors()
        {
            // arrange
            var user = new User("Adam", "da34fa");
            user.AddScore(5);
            user.AddScore(6);
            

            //act
            var result = user.Score;

            //assert
            Assert.AreEqual(11, result);

        }
    }
}