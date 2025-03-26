namespace ProjektCsharp;

public class Kontenerowca
{
    public List<Container> Containers { get; set; }
    public double MaxSpeed{get;set;}
    public int MaxNumberOfContainers{get;set;}
    public double TotalMaxMassTons{get;set;}
    public double TotalMass{get;set;}

    public Kontenerowca(List<Container> containers, double maxSpeed, int maxNumberOfContainers, double totalMaxMassTons)
    {
        Containers = containers;
        MaxSpeed = maxSpeed;
        MaxNumberOfContainers = maxNumberOfContainers;
        TotalMaxMassTons = totalMaxMassTons;
        for (int i = 0; i < Containers.Count; i++)
        {
            TotalMass += Containers[i].Massa;
        }
    }

    public void loadKontenerowc(Container container)
    {
        if (Containers.Count < MaxNumberOfContainers || TotalMass + container.Massa <= TotalMaxMassTons * 1000)
        {
            Containers.Add(container);
        }
        else
        {
            throw new OverFillException();
        }
    }

    public void removeKontener(String numerSeryjny)
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            if (numerSeryjny == Containers[i].NumerSeryjny)
            {
                Containers.RemoveAt(i);
            }
           
        }
    }

    public override String ToString()
    {
        string numerySeryjne = " ";
        for (int i = 0; i < Containers.Count; i++)
        {
            numerySeryjne += Containers[i].NumerSeryjny + ", ";
        }
        return numerySeryjne + " in konterowca " + MaxSpeed + " ktory moze jechac" + MaxNumberOfContainers + " max kontenerow w kontenerowcu " + TotalMaxMassTons;
    }
}