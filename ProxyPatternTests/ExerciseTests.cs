using ProxyPattern;
namespace ProxyPatternTests
{
    public class ExerciseTests
    {
        private readonly Person _person;
        private readonly IPerson _responsiblePerson;

        public ExerciseTests() 
        { 
            _person = new Person { Age = 10 };
            _responsiblePerson = new ResponsiblePerson(_person);
        }

        [Theory]
        [InlineData(10, "too young")]
        [InlineData(20, "driving")]
        public void Drive_WhenAge_Returns(int age, string expectedDrive)
        {
            // Arrange
            _responsiblePerson.Age = age;

            // Act
            var result = _responsiblePerson.Drive();

            // Assert
            Assert.Equal(expectedDrive, result);
        }

        [Theory]
        [InlineData(10, "too young")]
        [InlineData(20, "drinking")]
        public void Drink_WhenAge_Returns(int age, string expectedDrink)
        {
            // Arrange
            _responsiblePerson.Age = age;

            // Act
            var result = _responsiblePerson.Drink();

            // Assert
            Assert.Equal(expectedDrink, result);
        }

        [Theory]
        [InlineData(10, "dead")]
        [InlineData(20, "dead")]
        public void DrinkAndDrive_WhenAge10_ReturnsDead(int age, string expectedDrinkAndDrive)
        {
            // Arrange
            _responsiblePerson.Age = age;

            // Act
            var result = _responsiblePerson.DrinkAndDrive();

            // Assert
            Assert.Equal(expectedDrinkAndDrive, result);
        }
    }
}