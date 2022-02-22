using System.Collections.Generic;
namespace Contact.Domain.Contracts
{
  public interface IReadServices
  {
    public List<Entity> getAll();
  }
}
