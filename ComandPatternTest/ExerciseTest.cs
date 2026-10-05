using MediatorPattern.Exercise;

namespace ComandPatternTest
{
    public class ExerciseTest
    {
        [Fact]
        public void Test()
        {
            Mediator mediator = new Mediator();
            var p1 = new Participant(mediator);
            var p2 = new Participant(mediator);

            Assert.Equal(0, p1.Value);
            Assert.Equal(0, p2.Value);

            p1.Say(2);

            Assert.Equal(0, p1.Value);
            Assert.Equal(2, p2.Value);

            p2.Say(4);

            Assert.Equal(4, p1.Value);
            Assert.Equal(2, p2.Value);
        }
    }
}