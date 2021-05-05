using System;
using Xunit;

namespace Methods.Simple
{
    public class MainTests
    {
        [Fact]
        public void Doctor_should_not_be_available_because_of_existing_operation()
        {
            var run = new Run();

            var result = run.IsAvailable(DateTime.Now.AddHours(1), DateTime.Now.AddHours(3));
            Assert.False(result);
        }

        [Fact]
        public void Doctor_should_not_be_available_because_of_existing_vacation()
        {
            var run = new Run();

            var result = run.IsAvailable(DateTime.Now.AddDays(1), DateTime.Now.AddDays(2));
            Assert.False(result);
        }

        [Fact]
        public void Doctor_should_be_available()
        {
            var run = new Run();

            var result = run.IsAvailable(DateTime.Now.AddHours(3).AddMinutes(1), DateTime.Now.AddHours(4).AddMinutes(-1));
            Assert.True(result);

            result = run.IsAvailable(DateTime.Now.AddDays(3).AddMinutes(1), DateTime.Now.AddDays(4).AddMinutes(-1));
            Assert.True(result);
        }

        [Fact]
        public void Should_throw_exception_because_of_bad_input()
        {
            var run = new Run();

            Assert.Throws<InvalidOperationException>(() => run.IsAvailable(DateTime.Now.AddDays(3), DateTime.Now.AddDays(2)));
        }
    }
}
