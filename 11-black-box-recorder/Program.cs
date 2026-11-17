string path = "blackbox.txt";

// TODO: Hvis filen ikke finnes, skriv eksempeldata.
// TODO: Les så alle linjene og skriv dem ut.
if (File.Exists(path))
{
    Console.WriteLine("filen finnes");
    Console.WriteLine(File.ReadAllText(path));
}
else
{
    File.WriteAllText(path, "a");
    Console.WriteLine("lager fil");
}