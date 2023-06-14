using NUnit.Framework;

namespace HelloWorld.Tests
{
    public class HelloWorldTests
    {
        [Test]
        public void say_hello_world()
        {
            Greeter greeter = new Greeter();
            Assert.AreEqual("Hello World!", greeter.SayHelloWorld());
        }
    }
}