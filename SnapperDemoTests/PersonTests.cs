using NUnit.Framework;
using Snapper;
using SnapperDemo;

namespace SnapperDemoTests
{
    [TestFixture]
    public class PersonTests
    {
        private const string defaultName = "jorge";
        private Person person;

        [SetUp]
        public void Setup()
        {
            person = new Person(defaultName);
        }

        [Test]
        public void CtorWorks()
        {
            person.ShouldMatchSnapshot();
        }

        [Test]
        public void GetterAndSetterWork()
        {
            person.Name = "nonell";
            person.ShouldMatchSnapshot();
        }
    }
}
