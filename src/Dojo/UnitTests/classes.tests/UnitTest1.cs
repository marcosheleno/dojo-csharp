using NUnit.Framework;
using Contact.Domain.Email;
using Contact.Domain.Group;
using Contact.Domain.Phone;


namespace classes.tests;

[TestClass]
public class Tests
{
    [Test]
    public void TestEmail()
    {
        Email.Entity e = new Email(1, "abominavel.homem.neves@familia.snow", "comercial");

        Assert.AreEqual(1, e.id);
        Assert.AreEqual("abominavel.homem.neves@familia.snow", e.email);
        Assert.AreEqual("comercial", e.type);
    }

    [Test]
    public void TestGroup()
    {
        Group.Entity g = new Group("nevesGroup");

        Assert.AreEqual("nevesGroup", g.groupName);
    }

    [Test]
    public void TestPhone()
    {
        Phone.Entity p = new Phone(1, 999988888, 55, Comercial);

        Assert.AreEqual(1, p.id);
        Assert.AreEqual(999988888, p.phone);
        Assert.AreEqual(55, p.ddi);
        Assert.AreEqual("Comercial", p.type);

    }
}