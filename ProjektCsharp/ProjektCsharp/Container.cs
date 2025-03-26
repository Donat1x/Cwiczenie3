namespace ProjektCsharp;

public class Container : OverFillException
{
    public double Massa { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    public String NumerSeryjny { get; set; }
    public double MaxMassa { get; set; }
    public Container(double massaPerKg, double heightCm, double weightWlasnaKg, double depthCm, String numerSeryjny, double maxMassKg )
    {
        Massa = massaPerKg;
        Height = heightCm;
        Weight = weightWlasnaKg;
        Depth = depthCm;
        NumerSeryjny = numerSeryjny;
        MaxMassa = maxMassKg;
    }

    public virtual void emptyingContainer()
    {
        Massa = 0;
    }

    public virtual void loadingContainer(double massaToLoad)
    {
        if (massaToLoad > MaxMassa)
        {
            throw new OverFillException();
        }

        Massa += massaToLoad;
    }
    
    
}