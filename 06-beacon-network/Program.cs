Beacon one = new Beacon(101);
Beacon two = new Beacon(205);
Beacon three = new Beacon(330);
Beacon four = new Beacon(150);
Beacon five = new Beacon(124);
Beacon six = new Beacon(290);

Console.WriteLine(one.Frequency);
Console.WriteLine(two.Frequency);
Console.WriteLine(three.Frequency);
Console.WriteLine(four.Frequency);
Console.WriteLine(five.Frequency);
Console.WriteLine(six.Frequency);
Console.WriteLine($"Created: {Beacon.CreatedCount}");
