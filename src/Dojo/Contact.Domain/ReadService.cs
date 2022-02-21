using System.Collections.Generic;

using Contact.Domain.Contracts;
namespace Contact.Domain
{ 
  public class ReadService : IReadServices
  {

    IRepository _repository;

    public ReadService(IRepository repository) {
      _repository = repository;
    }

    public List<Entity> getAll()
    {
      return _repository.getAll();
    }
  }
}