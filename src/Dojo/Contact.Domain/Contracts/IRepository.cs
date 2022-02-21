using System.Collections.Generic;
namespace Contact.Domain.Contracts
{
  public interface IRepository
  {
    public List<Entity> getAll();
  }
}