using NUnit.Framework;
using Exercise.Factory;

namespace FactoryUT
{
    [TestFixture]
    public class TestSuite
    {
        [Test]
        public void Test()
        {
            var pf = new PersonFactory();

            var p1 = pf.CreatePerson("Fernando");
            Assert.That(p1.Name, Is.EqualTo("Fernando"));
            Assert.That(p1.Id, Is.EqualTo(0));

            var p2 = pf.CreatePerson("Taynara");
            Assert.That(p2.Id, Is.EqualTo(1));
        }
    }
}
