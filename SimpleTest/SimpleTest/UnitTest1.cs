namespace SimpleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            bool f = true;
            Assert.True(f);
        }
    }
}