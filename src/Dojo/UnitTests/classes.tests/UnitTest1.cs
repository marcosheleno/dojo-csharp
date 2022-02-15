using NUnit.Framework;
using Contact.Domain.Contact;

namespace classes.tests;

[TestClass]
public class Tests
{
    [Test]
    public void Test1()
    {
        Contact c = new Contact(1, name, emails, phones, groups);
        c.id = 1;

        Assert.AreEqual(30, Is.EqualTo(id));
    }
}