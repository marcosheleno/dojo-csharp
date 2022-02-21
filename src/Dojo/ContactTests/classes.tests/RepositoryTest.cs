using Contact.Domain;
using Contact.Infrastructure;
using System;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using Archive = Infrastructure.Persistance.Archive;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace classes.tests;

public class RepositoryTest
{
    [Test]
    public void TestRepositoryCanHaveEmptyList()
    {
        var a = JsonConvert.DeserializeObject(@"[]").ToString();
        dynamic dynObj = JsonConvert.DeserializeObject(a);

        var jsonMock = new Moq.Mock<Archive.JsonReader>();
        jsonMock.Setup(c => c.read(It.IsAny<string>())).Returns(dynObj);

        Repository repo = new Repository(jsonMock.Object);

        Assert.IsEmpty(repo.getAll());
    }

    [Test]
    public void TestRepositoryCanHasContact()
    {
        var a = JsonConvert.DeserializeObject(@"[{'id': '00000000-9999-0000-0000-000000000000', 'name': 'João das neves'}]").ToString();
        dynamic dynObj = JsonConvert.DeserializeObject(a);

        var jsonMock = new Moq.Mock<Archive.JsonReader>();
        jsonMock.Setup(c => c.read(It.IsAny<string>())).Returns(dynObj);

        Repository repo = new Repository(jsonMock.Object);


        Assert.IsNotEmpty(repo.getAll());
    }

    [Test]
    public void TestRepositoryCanHasContactWithGroups()
    {
        var a = JsonConvert.DeserializeObject(@"[{'id': '00000000-9999-0000-0000-000000000000', 'name': 'João das neves', 'groups': ['familia neves', 'chatos']}]").ToString();
        dynamic dynObj = JsonConvert.DeserializeObject(a);

        var jsonMock = new Moq.Mock<Archive.JsonReader>();
        jsonMock.Setup(c => c.read(It.IsAny<string>())).Returns(dynObj);

        Repository repo = new Repository(jsonMock.Object);
        List<Entity> list = repo.getAll();

        Assert.IsNotEmpty(list);

        var groups = list[0].Groups;
        Assert.AreEqual(false, groups.IsEmpty());


    }

    [Test]
    public void TestRepositoryCanHasContactWithPhones()
    {
        var a = JsonConvert.DeserializeObject(@"[{'id': '00000000-9999-0000-0000-000000000000', 'name': 'João das neves', 'phones': [{}]}]").ToString();
        dynamic dynObj = JsonConvert.DeserializeObject(a);

        var jsonMock = new Moq.Mock<Archive.JsonReader>();
        jsonMock.Setup(c => c.read(It.IsAny<string>())).Returns(dynObj);

        Repository repo = new Repository(jsonMock.Object);
        List<Entity> list = repo.getAll();

        Assert.IsNotEmpty(list);
        var phones = list[0].Phones;
        Assert.AreEqual(false, phones.IsEmpty());
    }
}
