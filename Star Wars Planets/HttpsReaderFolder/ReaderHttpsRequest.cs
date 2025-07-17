

using ReaderHttps;
using StarWarsPlanetsStats.ApiDataAccess;
using StarWarsPlanetsStats.DOts;
using System.Text.Json;

public class ReaderHttpsRequest(IAlternativeApiDataReader mockStarWarsApiDataReader) : IReaderHttpsRequset
{
    public async Task<IEnumerable<Planet>> Read()
    {
        Root deslirztion = JsonSerializer.Deserialize<Root>(await mockStarWarsApiDataReader.Read())!;

        return CollictionOfPlants(deslirztion, new ArgumentNullException(@"Sorry... Server Is Down Right Now"));

    }
    public IEnumerable<Planet> CollictionOfPlants(Root? deslirztion, Exception argumentNullException) => deslirztion is null ?
        throw argumentNullException :
        deslirztion.results.Select(item => (Planet)item);
}
