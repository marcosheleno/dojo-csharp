using System;
using Moq;
using NUnit.Framework;
using NamespaceContact = Contact.Domain;
using NamespaceEmail = Contact.Domain.Email;
using NamespaceGroup = Contact.Domain.Group;
using NamespacePhone = Contact.Domain.Phone;


namespace classes.tests;

[TestFixture]
public class Tests
{
    private Mock<NamespaceEmail.Entity> mockEmail;
    private Mock<NamespaceGroup.Entity> mockGroup;
    private Mock<NamespacePhone.Entity> mockPhone;

    [SetUp]
    public void Setup(){
        mockEmail = new Mock<NamespaceEmail.Entity>();
        mockGroup = new Mock<NamespaceGroup.Entity>();
        mockPhone = new Mock<NamespacePhone.Entity>();
    }

    [Test]
    public void TestEmail()
    {
        Guid idEmail = Guid.NewGuid();
        NamespaceEmail.Entity email = new NamespaceEmail.Entity(idEmail, "abominavel.homem.neves@familia.snow", "comercial");

        Assert.AreEqual(idEmail, email.Id);
        Assert.AreEqual("abominavel.homem.neves@familia.snow", email.Email);
        Assert.AreEqual("comercial", email.Type);
    }

    [Test]
    public void TestGroup()
    {
        NamespaceGroup.Entity group = new NamespaceGroup.Entity("nevesGroup");

        Assert.AreEqual("nevesGroup", group.GroupName);
    }

    [Test]
    public void TestPhone()
    {
        Guid idPhone = Guid.NewGuid();
        NamespacePhone.Entity phone = new NamespacePhone.Entity(idPhone, 999988888, 55, "Comercial");

        Assert.AreEqual(idPhone, phone.Id);
        Assert.AreEqual(999988888, phone.Phone);
        Assert.AreEqual(55, phone.Ddi);
        Assert.AreEqual("Comercial", phone.Type);
    }

    [Test]
    public void TestContacts()
    {
        Guid idContact = Guid.NewGuid();

        //mock.Setup(email.Email).Returns("jose.iebt@gmail.com");
        NamespaceEmail.Entity[] emails = new NamespaceEmail.Entity(mockEmail.Object);
        NamespaceEmail.Entity[] groups = new NamespaceEmail.Entity(mockGroup.Object);
        NamespaceEmail.Entity[] phones = new NamespaceEmail.Entity(mockPhone.Object);

        NamespaceContact.Entity contact = new NamespaceContact.Entity(idContact, "José", emails, 999998888, "iebt");

        Assert.AreEqual(idContact, contact.Id);
        Assert.AreEqual(999988888, contact.Phone);
        Assert.AreEqual(55, contact.Ddi);
        Assert.AreEqual("Comercial", contact.Type);
    }
}
