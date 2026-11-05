public class Drone
{
    public string Name { get; set; }
    public int FlightHours { get; set; }

    public Drone(string name, int flightHours)
    {
        Name = name;
        FlightHours = flightHours;
    }

    public string Describe()
    {
        // TODO
        return Name;
    }

    public bool NeedsService()
    {
        // TODO
        if (FlightHours >= 100)
        {
            return true;
        }
        else{
            return false;
        }
    }
}
