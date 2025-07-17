namespace StarWarsPlanetsStats.ApiDataAccess;

public interface IAlternativeApiDataReader
{
    Task<string> Read();
}
