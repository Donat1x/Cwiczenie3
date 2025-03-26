namespace ProjektCsharp;

class Program
{
    static void Main()
    {
        Container container = new Container(500, 1000, 1000, 250, "s2312", 3000);
        ContainerL containerL = new ContainerL(800, 3000, 2000, 250, "s23142", 6000, true);
        ContainerC containerC = new ContainerC(700, 1400, 800, 150, "s23123", 4000, "banan", 3.5);
        ContainerG containerG = new ContainerG(1200, 2000, 2000, 550, "s2311", 8000);
        List<Container> containers = new List<Container>();
        containers.Add(container);
        containers.Add(containerL);
        containers.Add(containerC);
        containers.Add(containerG);
        Kontenerowca kontenerowca = new Kontenerowca(containers, 95.5, 10, 40);
        Console.WriteLine(container.Massa);
        container.loadingContainer(30);
        Console.WriteLine(container.Massa);
        containerL.loadingContainer(5500);
        Console.WriteLine(containerG.Massa);
        containerG.emptyingContainer();
        Console.WriteLine(containerG.Massa);
        kontenerowca.loadKontenerowc(container);
        Console.WriteLine(kontenerowca);
        kontenerowca.removeKontener("s2312");
        Console.WriteLine(kontenerowca);
         container.loadingContainer(300000);
    }
}