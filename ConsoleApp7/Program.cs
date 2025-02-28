using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Random rand = new Random();
        List<allatok> animals = new List<allatok>
        {
            new viziallat("Delfin", rand.Next(10, 30)),
            new hidegallat("Jegesmedve", rand.Next(5, 15)),
            new mediterranallat("Muflon", rand.Next(10, 20)),
            new melegallat("Oroszlán", rand.Next(15, 25)),
            new tropusiallat("Jaguár", rand.Next(20, 30))
        };

        int zooCapacity = rand.Next(5, 15);
        List<allatok> zoo = new List<allatok>(animals.GetRange(0, Math.Min(zooCapacity, animals.Count)));

        Console.WriteLine($"\nÁllatkert kapacitása: {zooCapacity}, Jelenlegi állatok száma: {zoo.Count}");
        int filledPercentage = (int)((double)zoo.Count / zooCapacity * 10);
        Console.WriteLine("Állatkert telítettsége: [" + new string('#', filledPercentage) + new string('-', 10 - filledPercentage) + "]");

        Race(zoo);
    }

    static void Race(List<allatok> allatok)
    {
        Console.WriteLine("\nVerseny kezdődik! Ki a leggyorsabb?");
        int maxSpeed = 0;
        foreach (var allat in allatok)
        {
            if (allat.Speed > maxSpeed)
                maxSpeed = allat.Speed;
        }

        for (int step = 0; step < maxSpeed; step++)
        {
            foreach (var allat in allatok)
            {
                if (step < allat.Speed)
                {
                    Console.WriteLine($"{allat.Name,-10} |" + new string(' ', step) + "O");
                }
            }
            Console.WriteLine();
        }
    }
}
