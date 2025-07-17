

using ReaderHttps;
using StarWarsPlanetsStats.ApiDataAccess;
using StarWarsPlanetsStats.DOts;







try
{
    var RunProgrem = new StarWarsStartingApp(
  new ReaderHttpsRequest(new AlternativeApiDataReader())
  ,
  new DisplayStatistics(
      new InterActionToUser()
      )
    );
    await RunProgrem.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Invalid In Progrem " +
        "The Message IS " + ex.Message);
}
Console.WriteLine("press Any Key ");
Console.ReadKey();


public class StarWarsStartingApp(IReaderHttpsRequset _ReaderHttpsRequset, IDisplayStatistics _IdisplayStatistics)
{
    public async Task Run()
    {
        var ReaderResponspility = await _ReaderHttpsRequset.Read();


        converterMethod(ReaderResponspility);


        _IdisplayStatistics.ShowSelectedPropertyStats(ReaderResponspility);
    }

    private static void converterMethod<T>(IEnumerable<T> Items)
    {
        int ColumWidth = 15;
        var ThePropertys = typeof(T).GetProperties();

        foreach (var Property in ThePropertys)
        {
            Console.Write($"{{0,-{ColumWidth}}}|", $"{Property.Name}");

        }
        Console.WriteLine();
        Console.WriteLine(new string('-', (ColumWidth + 1) * ThePropertys.Count()));

        foreach (var item in Items)
        {
            foreach (var Property in ThePropertys)
            {
                Console.Write($"{{0,-{ColumWidth}}}|", $"{Property.GetValue(item)}");

            }
            Console.WriteLine();
        }

    }
}


public interface IDisplayStatistics
{
    public void ShowSelectedPropertyStats(IEnumerable<Planet> ReaderResponspility);
}
public class DisplayStatistics(IInterActionToUser _interActionToUser) : IDisplayStatistics
{
    public void ShowSelectedPropertyStats(IEnumerable<Planet> ReaderResponspility)
    {
        var PlanteDicionary = new Dictionary<string, Func<Planet, long?>>()
        {
            ["population"] = x => x.Poupulition,
            ["Diameter"] = x => x.Diameter,
            ["SurfaceWater"] = x => x.SurfaceWater
        };

        _interActionToUser.ShowMessage("");
        _interActionToUser.ShowMessage(@"The statistics of which property would you like to see? ");
        _interActionToUser.ShowMessage(string.Join(
            Environment.NewLine,
            PlanteDicionary.Keys));

        var InputParmeter = _interActionToUser.ReaderFromUser();

        if (InputParmeter is null || !PlanteDicionary.TryGetValue(InputParmeter, out Func<Planet, long?>? value))
        {
            _interActionToUser.ShowMessage("Invalid Choice");
        }
        else
        {
            StaticticsMethod(ReaderResponspility, value);
        }

    }
    private static void StaticticsMethod(IEnumerable<Planet> collictionMethod, Func<Planet, long?> PropertySelector)
    {
        ShowStatictes(
            "Max",
            PropertySelector,
            collictionMethod.MaxBy(PropertySelector)
            );


        ShowStatictes(
                "Min",
                PropertySelector,
                collictionMethod.MinBy(PropertySelector)
                );
    }

    private static void ShowStatictes(string Describtion, Func<Planet, long?> propertySelector, Planet planet)
    {
        Console.WriteLine($"{Describtion},{propertySelector(planet)}: PlanteName {planet.Name}");
    }


}

public interface IInterActionToUser
{
    public string? ReaderFromUser();

    public void ShowMessage(string message);


}
public class InterActionToUser : IInterActionToUser
{
    public string? ReaderFromUser()
    {
        Console.WriteLine();
        return Console.ReadLine();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
