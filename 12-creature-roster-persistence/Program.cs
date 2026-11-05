string path = "creatures.txt";
/*string bok1 = "";
string bok2 = "";
string bok3 = "";
int bo = 0;*/
List<Creature> creatures = new List<Creature>
{
    new Creature("Mora", "Lumen Fox", 72),
    new Creature("Kip", "Dust Eel", 18),
    new Creature("Senn", "Cloud Moth", 41)
};
List<string> cre = new List<string>{};
File.WriteAllText(path, "");
//File.AppendAllText(path, " ");
for (int i = 0; i < creatures.Count; i++)
{
    cre.Add($"{creatures[i].Name}|{creatures[i].Species}|{creatures[i].Energy}");
    //File.AppendAllText(path, $"{creatures[i].Name}  {creatures[i].Species}  {creatures[i].Energy}   ");  
}
File.WriteAllLines(path, cre);
string[] cL = (File.ReadAllLines(path));
for (int i = 0; i < cL.Count(); i++)
{
    Console.WriteLine(cL[i]);
}