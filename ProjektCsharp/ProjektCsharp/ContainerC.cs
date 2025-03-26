namespace ProjektCsharp;

public class ContainerC : Container
{
    public String RodzajProduktu  {get; set;}
    public double Temperature { get; set; }
    
    public ContainerC(double massaPerKg, double heightCm, double weightWlasnaKg, double depthCm, string numerSeryjny, double maxMassKg, string rodzajProduktu, double temperature) : base(massaPerKg, heightCm, weightWlasnaKg, depthCm, numerSeryjny, maxMassKg)
    {
        RodzajProduktu = rodzajProduktu;
        Temperature = temperature;
    }
}