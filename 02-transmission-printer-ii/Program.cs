
class Program{
    static void Main(string[] args){
        Print pr = new Print();
        pr.PrintTransmission("System ready");
        pr.PrintTransmission("Dock", "Gate unlocked");
        pr.PrintTransmission("Dock", "Gate loced", 6);
    }
}
// TODO: Kall også din tredje overload.
public class Print{
    public void PrintTransmission(string message)
    {
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    public void PrintTransmission(string sender, string message)
    {
        Console.WriteLine($"[{sender}] {message}");
    }
    public void PrintTransmission(string sender, string message, int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"[{sender}] {message}");    
        }
    }
    public void PrintTransmission(string what, int number)
    {
        if (number > 1)
        {
            Console.WriteLine($"there are {number} {what}s");   
        }
        else
        {
            Console.WriteLine($"there are {number} {what}");
        }
    }
}
// TODO: Lag tredje overload.
