class Program{
    static void Main(string[] args){
        Print pr = new Print();
        pr.PrintTransmission("Calibration complete");
        pr.PrintTransmission("Relay-7", "Signal acquired");
    }
}
public class Print{
    public void PrintTransmission(string message)
    {
        // TODO
        Console.WriteLine(message);
    }
    public void PrintTransmission(string sender, string message)
    {
        // TODO
        Console.WriteLine($"{message} from {sender}");
    }
}