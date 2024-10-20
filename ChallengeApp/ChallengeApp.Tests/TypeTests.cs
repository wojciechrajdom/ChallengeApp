
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
            var employee1 = GetUser("Wojtek");
            var employee2 = GetUser("Wojtek");
            // act

            // assert
            Assert.AreEqual(employee1.Name, employee2.Name);

        }
        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}

