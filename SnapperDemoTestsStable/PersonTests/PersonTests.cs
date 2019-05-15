using NUnit.Framework;
using Snapper.Json.Nunit;
using SnapperDemo;
using Is = Snapper.Json.Nunit.Is;

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
            Assert.That(person, Is.EqualToSnapshot());
        }

        [Test]
        public void GetterAndSetterWork()
        {
            person.Name = "luis";
            Assert.That(person, Is.EqualToSnapshot("update1"));

            person.Name = "nonell";
            Assert.That(person, Is.EqualToSnapshot("update2"));
        }
    }
}
