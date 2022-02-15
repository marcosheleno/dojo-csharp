using NUnit.Framework;
using Contact.Domain.Email.Entity;

namespace classes.tests;

[TestClass]
public class Tests
{
    [Test]
    public void Test1()
    {
        //Moq.Mock<Email.Entity> emailMock = new Moq.Mock<Email.Entity>();
        //emailMock.Setup();
        Email.Entity e = new Email(1, "abominavel.homem.neves@familia.snow", "comercial");

        Assert.AreEqual(1, e.id);
        Assert.AreEqual("abominavel.homem.neves@familia.snow", e.email);
        Assert.AreEqual("comercial", e.type);
    }
}