using Xunit;

namespace Naming.Meaning
{
    public class MainTests
    {
        [Fact]
        public void Counts_student_active_courses()
        {
            var run = new Run();
            
            Assert.Equal(5, run.Count());
            run.AddCourse();
            Assert.Equal(6, run.Count());
            run.AddCourse();
            Assert.Equal(6, run.Count());
        }
    }
}
