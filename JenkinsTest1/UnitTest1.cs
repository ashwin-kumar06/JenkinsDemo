using JenkinsDemo;
namespace JenkinsTest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSayHello1()
        {
            TestThis obj1= new TestThis();
            string result = obj1.SayHello(3);
            Assert.AreEqual("HelloHelloHello", result);
        }

        [Test] 
        public void TestSayHello2() 
        { 
            TestThis obj2= new TestThis();
            string result = obj2.SayHello(1);
            Assert.AreEqual("Hello", result);
        }
    }
}