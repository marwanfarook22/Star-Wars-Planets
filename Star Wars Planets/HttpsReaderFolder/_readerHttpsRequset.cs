using StarWarsPlanetsStats.DOts;

namespace ReaderHttps
{
    public interface IReaderHttpsRequset
    {
        public Task<IEnumerable<Planet>> Read();
        public IEnumerable<Planet> CollictionOfPlants(Root? deslirztion, Exception argumentNullException);

    }
}