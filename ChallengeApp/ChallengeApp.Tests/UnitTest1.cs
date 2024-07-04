using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckinSumPointsOfEmployees()
        {
            // arrange
            var employee = new Employee("Wojtek", "Glowa", "39");
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(5);
            employee.AddScore(8);
            employee.AddScore(4);
            employee.AddScore(-20);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(7, result);

        }
    }
}