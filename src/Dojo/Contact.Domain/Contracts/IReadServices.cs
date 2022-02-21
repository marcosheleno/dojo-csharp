using System.Collections.Generic;
namespace Contact.Domain.Contracts
{
  interface IReadServices
  {
    public List<Entity> getAll();
  }
}