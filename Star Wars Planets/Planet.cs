using Star_Wars_Planets.Exstionstion;
using StarWarsPlanetsStats.DOts;

public readonly struct Planet
{
    public string Name { get; }
    public int Diameter { get; }
    public long? Poupulition { get; }
    public long? SurfaceWater { get; }

    public Planet(string name, int diameter, long? poupulition, long? surfaceWater)
    {
        ArgumentNullException.ThrowIfNull(name);
        Name = name;
        Diameter = diameter;
        Poupulition = poupulition;
        SurfaceWater = surfaceWater;
    }
    public static explicit operator Planet(Result plante)
    {
        string Name = plante.name;
        int Diameter = int.Parse(plante.diameter);
        long? Populition = plante.population.IntegerOrNull();
        long? SurfaceWater = plante.surface_water.IntegerOrNull();

        return new Planet(Name, Diameter, Populition, SurfaceWater);
    }


    public override string ToString()
    {
        return $"{Name}   |{Diameter} |{Poupulition}  |{SurfaceWater}";
    }
}


