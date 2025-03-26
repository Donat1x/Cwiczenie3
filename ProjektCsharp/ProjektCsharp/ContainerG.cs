namespace ProjektCsharp;

public class ContainerG : Container, IHazardNotifier
{
    public ContainerG(double massaPerKg, double heightCm, double weightWlasnaKg, double depthCm, string numerSeryjny, double maxMassKg) : base(massaPerKg, heightCm, weightWlasnaKg, depthCm, numerSeryjny, maxMassKg)
    {
        
    }

    public String messageOfDangerousSituation(String message, String numerSeryjny)
    {
        return message + " " + numerSeryjny;
    }

    public override void emptyingContainer()
    {
        Massa *= 0.05;
    }
}