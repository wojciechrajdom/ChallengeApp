namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void VarShouldReturnTheSameEqual()
        {
            // arrange
            var number1 = 5;
            var number2 = 5;
            // act


            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void UserShouldReturnTheSameParameters()
        {
            // arrange
            var user1 = GetUser("Wojtek");
            var user2 = GetUser("Wojtek");
            // act


            // assert
            Assert.AreEqual(user1.Login, user2.Login);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
