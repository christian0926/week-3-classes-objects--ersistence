

namespace Pr{
    class Program{
        static void Main(string[] args){
            Creature first = new Creature();  
            Creature second = new Creature();
            Creature third = new Creature();  
            first.Name = "Tommy";
            first.Species = "ape";
            first.Energy = 5;
            second.Name = "Jeff";
            second.Species = "Hund";
            second.Energy = 3;
            third.Name = "Alexsander";
            third.Species = "Romvesen";
            third.Energy = 11;
            Console.WriteLine($"{first.Species}, {first.Name}, {first.Energy}");
            Console.WriteLine($"{second.Species}, {second.Name}, {second.Energy}");
            Console.WriteLine($"{third.Species}, {third.Name}, {third.Energy}");
        }
    }
}
// TODO: Sett properties til ulike verdier.
// TODO: Skriv verdiene for alle tre objektene.
