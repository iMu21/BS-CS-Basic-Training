
public enum PlanetRadius
{
    Jupiter = 71492,
    Saturn = 60268,
    Uranus = 25559,
    Neptune = 24764,
    Earth = 6378,
    Venus = 6052,
    Mars = 3396,
    Mercury = 2439,
    Moon = 1738,
    Pluto = 1195

}
class enumDeclaration
{
    public static double AreaOfPlanet(PlanetRadius planet)
    {
        return Math.PI * (double)((int)planet * (int)planet);
    }
    public static void Main(string[] args)
    {

        PlanetRadius planet = PlanetRadius.Earth;
        Console.WriteLine($"Area of {planet} is {AreaOfPlanet(planet)} km^2");

    }
}