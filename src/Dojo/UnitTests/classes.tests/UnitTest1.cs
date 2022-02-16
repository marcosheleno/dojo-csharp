using System;
using NUnit.Framework;
using NamespaceEmail = Contact.Domain.Email;
using NamespaceGroup = Contact.Domain.Group;
using NamespacePhone = Contact.Domain.Phone;


namespace classes.tests;

[TestFixture]
public class Tests
{
    [Test]
    public void TestEmail()
    {
        Guid idEmail = Guid.NewGuid();
        NamespaceEmail.Entity email = new NamespaceEmail.Entity(idEmail, "abominavel.homem.neves@familia.snow", "comercial");

        Assert.AreEqual(idEmail, email.Id);
        Assert.AreEqual("abominavel.homem.neves@familia.snow", email.getEmail);
        Assert.AreEqual("comercial", email.getTypeEmail);
    }

    [Test]
    public void TestGroup()
    {
        NamespaceGroup.Entity group = new NamespaceGroup.Entity("nevesGroup");

        Assert.AreEqual("nevesGroup", group.groupName);
    }

    [Test]
    public void TestPhone()
    {
        NamespacePhone.Entity phone = new NamespacePhone.Entity(1, 999988888, 55, Comercial);

        Assert.AreEqual(1, phone.Id);
        Assert.AreEqual(999988888, phone.phone);
        Assert.AreEqual(55, phone.ddi);
        Assert.AreEqual("Comercial", phone.type);

    }
}
