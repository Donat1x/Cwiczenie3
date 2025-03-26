using System.ComponentModel;

namespace ProjektCsharp;

public class ContainerL : Container, IHazardNotifier
{
    public bool Dangerous { get; set; }
    public ContainerL(double massaPerKg, double heightCm, double weightWlasnaKg, double depthCm, string numerSeryjny, double maxMassKg, bool dangerous) : base(massaPerKg, heightCm, weightWlasnaKg, depthCm, numerSeryjny, maxMassKg)
    {
        Dangerous = dangerous;
    }

    public String messageOfDangerousSituation(string message, string containerNumber)
    {
        return message + " " + containerNumber;
    }

    public override void loadingContainer(double massaToLoad)
    {
        if (Dangerous)
        {
            if (MaxMassa / 2 < massaToLoad)
            {
                Console.WriteLine("Niebezpieczna sytuacja ladowania na więcej niz 50 % dopuscimej massy,",
                    NumerSeryjny);
            }
            else
            {
                Massa += massaToLoad;
            }
        }
        else
        {
            if (MaxMassa * 0.9 < massaToLoad)
            {
                messageOfDangerousSituation("Niebezpieczna sytuacja ladunku o wiecej niz 90% dopuscimej massy,",
                    NumerSeryjny);
            }
            else
            {
                Massa += massaToLoad;
            }
        }
    }
    
    
}