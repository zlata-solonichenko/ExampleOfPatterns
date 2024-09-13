namespace SingletonPattern;

class Planet
{
    private static Planet instance;

    public string Name { get; private set; }
    
    protected Planet(string name)
    {
        this.Name = name;
    }
    
    public static Planet getInstance(string name)
    {
        if (instance == null)
            instance = new Planet(name);
        return instance;
    }
}