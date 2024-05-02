// ReSharper disable InconsistentNaming
namespace Example.Singleton;

public class SingletonExample
{

    private static readonly object padlock = default!;
    private static SingletonExample? instance;

    private SingletonExample()
    {

    }

    public static SingletonExample Instance
    {

        get
        {
            lock (padlock)
            {
                instance ??= new SingletonExample();
            }
            return instance;
        }

    }

}