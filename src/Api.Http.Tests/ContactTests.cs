using Contact.Domain;
using NUnit.Framework;
using Infra = Infrastructure.Persistance.Archive;
using ContactInfra = Contact.Infrastructure;
using ContactDomain = Contact.Domain;


namespace Api.Http.Tests;

public class ContactTests
{
    [SetUp]
    public void ContactTest()
    {


        var jsonReaderMock = new Moq.Mock<Infra.JsonReader>();
        Infra.JsonReader jsonReader = jsonReaderMock.Object;

        var contactRepositoryMock = new Moq.Mock<ContactInfra.Repository>();
        contactRepositoryMock.Setup(c => c.Add(jsonReaderMock));
        ContactInfra.Repository contactRepository = contactRepositoryMock.Object;

        var readServiceMock = new Moq.Mock<ContactDomain.ReadService>();
        readServiceMock.Setup(c => c.Add(contactRepositoryMock));
        ContactDomain.ReadService readService = readServiceMock.Object;

        readServiceMock.getAll();

        // Infra.JsonReader jsonReader = new Infra.JsonReader();
        // ContactInfra.Repository contactRepository = new ContactInfra.Repository(jsonReader);
        // ContactDomain.ReadService readService = new ContactDomain.ReadService(contactRepository);
    }

}
