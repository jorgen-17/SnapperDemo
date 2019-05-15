using NUnit.Framework;
using Snapper;
using Snapper.Attributes;
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
            person.Name = "luis";
            person.ShouldMatchChildSnapshot("update1");

            person.Name = "nonell";
            person.ShouldMatchChildSnapshot("update2");
        }
    }
}
