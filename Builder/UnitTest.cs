using NUnit.Framework;

namespace Coding.Exercise
{
    [TestFixture]
    public class TestSuite
    {
        private static string PreProcess(string s)
        {
            return s.Trim();
        }

        [Test]
        public void EmptyTest()
        {
            var cb = new CodeBuilder("Foo");
            Assert.That(PreProcess(cb.ToString()), Is.EqualTo("public class Foo\n{\n}"));
        }

        [Test]
        public void PersonTest()
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Assert.That(PreProcess(cb.ToString()),
              Is.EqualTo(
                @"public class Person
{
  public string Name;
  public int Age;
}"
              ));
        }
    }
}
