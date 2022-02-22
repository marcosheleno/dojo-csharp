namespace Infrastructure.Persistance.Archive
{
  public interface IJsonReader
  {
    public dynamic read(string path);
  }
}
