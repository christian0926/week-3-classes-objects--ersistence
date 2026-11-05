public class ArtifactCatalog
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        // TODO
        artifacts.Add(artifact);
    }

    public void PrintAll()
    {
        
        Console.WriteLine(artifacts.Count);
        // TODO
        for (int i = 0; i < artifacts.Count; i++)
        {
            
            Console.WriteLine(artifacts[i].Name + "  " + artifacts[i].Origin);
        }
    }

    public Artifact FindByName(string name)
    {
        // TODO: Finn manuelt med løkke.
        for (int i = 0; i < artifacts.Count; i++)
        {
            if (artifacts[i].Name == name)
            {
                return artifacts[i];
            }
        }
        return null;
    }
}
