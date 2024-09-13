namespace SingletonPattern;

class Moon
{
    public Planet Planet { get; set; }

    public void Create(string planetName)
    {
        Planet = Planet.getInstance(planetName);
    }
}