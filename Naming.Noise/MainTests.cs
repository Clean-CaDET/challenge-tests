using System;
using Xunit;

namespace Naming.Noise
{
    public class MainTests
    {
        [Fact]
        public void Adding_existing_specialization_throws_exception()
        {
            var run = new Run();

            Assert.ThrowsAny<Exception>(() => run.AddSpec());
        }

        [Fact]
        public void Has_correct_specializations()
        {
            var run = new Run();

            var all = run.GetSpec();
            Assert.True(all.Count == 3);
            Assert.True(run.HasSpec(all));

            all.Add(null);
            Assert.False(run.HasSpec(all));
        }
    }
}
