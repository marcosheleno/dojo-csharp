namespace Infrastructure.Persistance.Archive
{
  interface IJsonReader
  {
    public dynamic read(string path);
  }
}
