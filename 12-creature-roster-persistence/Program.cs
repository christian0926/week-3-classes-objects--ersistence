string path = "creatures.txt";
/*string bok1 = "";
string bok2 = "";
string bok3 = "";
int bo = 0;*/
List<Creature> creatures = new List<Creature>
{
    new Creature("Mora", "Lumen Fox", 72),
    new Creature("Kip", "Dust Eel", 18),
    new Creature("Senn", "Cloud Moth", 41),
    new Creature("h", "Cloud k", 47),
    new Creature("Senn", "a Moth", 43)
};
List<string> cre = new List<string>{};
File.WriteAllText(path, "");
//File.AppendAllText(path, " ");
for (int i = 0; i < creatures.Count; i++)
{
    cre.Add(creatures[i].Name);
    cre.Add(creatures[i].Species);
    cre.Add(creatures[i].Energy.ToString());
    File.AppendAllText(path, $"{creatures[i].Name}|{creatures[i].Species}|{creatures[i].Energy} |");
}
//File.WriteAllLines(path, cre);
//List<Creature> creaturesTilbake = new List<Creature>
//{
//    new Creature(File.ReadAllText(path)),
//};



string a = "";
a = File.ReadAllText(path);
a = a + "a";
Console.WriteLine(a);
int s = 0;
int s2 = 0;
List<string> a1 = new List<string>{};
a1.Add("");
while (true)
{
    while (true)
    {
        if (a[s] == '|')
        {
            s++;
            break;
        }
        a1[s2] += a[s];
        s++;
        if (s == a.Length)
        {
            break;
        }
    }
    if (s+1 == a.Length)
    {
        break;
    }
    a1.Add("");
    s2++;
}


List<Creature> creatures2 = new List<Creature>{};
for (int i = 0; i < a1.Count(); i+=3)
{
    creatures2.Add(new Creature(a1[i], a1[i+1], Int32.Parse(a1[i+2])));
}
for (int i = 0; i < creatures2.Count(); i++)
{
    Console.WriteLine($"{creatures2[i].Name}  {creatures2[i].Species}  {creatures2[i].Energy}");
}
//string[] cL = File.ReadAllLines(path);
//for (int i = 0; i < cL.Count(); i++)
//{
//    Console.WriteLine(cL[i]);
//}

