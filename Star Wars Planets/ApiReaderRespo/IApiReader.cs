public interface IApiReader
{
    Task<string> Reader(string Base, string ApiRequest);
}
