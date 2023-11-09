namespace CIOnWpfTest
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
            Assert.Pass();
        }

        [Test]
        public void ErrorTest() 
        {
            Assert.Throws<Exception>(() => 
            {
                throw new Exception();
            });
        }
    }
}