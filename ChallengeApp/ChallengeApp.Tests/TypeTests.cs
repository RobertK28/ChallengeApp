namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST_Value()
        { 
            //arrange
            int number1 = 1;
            int number2 = 1;
            string name1 = "Adam";
            string name2 = "Adam";
            double number3 = 3.33;
            double number4 = 3.33;

            //act

            //assert
            Assert.AreEqual(number1, number2);
            Assert.AreEqual(name1, name2);
            Assert.AreEqual(number3, number4);
        }

        [Test]
        public void TEST_Reference()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //act

            //assert
            Assert.AreNotEqual(user1, user2);  

        }
    
        private User GetUser(string name)
        {
            return new User(name);
        }
    
    }
}
