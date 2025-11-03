using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructures.Map;

public class MapDemo
{
    public MapDemo()
    {
        Console.WriteLine("\n===== Linear Hashmap Implementation =====");
        LinHashDemo();
        Console.WriteLine("\n===== Chaining Hashmap Implementation =====");
        ChainHashDemo();
    }
    public void LinHashDemo()
    {
        LinearHash linHash = new LinearHash(5);

        linHash.Put(1, "Joe");
        linHash.Put(2, "Dino");
        linHash.Put(3, "Timmy");
        linHash.Put(4, "Jonathan");
        linHash.Put(5, "Annie");
        linHash.Put(6, "Ernie");
        linHash.Put(7, "Vincent");
        linHash.Put(8, "Felix");
        linHash.Put(9, "Sabrina");

        linHash.About();

        Console.WriteLine("\nGet Joe (3)");
        var temp = linHash.Get(3);
        Console.WriteLine($" > {temp.Key}: {temp.Value}");

        Console.WriteLine("\nDelete Joe (3)");
        linHash.Delete(temp.Key);

        linHash.About();
    }


    public void ChainHashDemo()
    {
        ChainingHash chainHash = new ChainingHash(5);
        chainHash.Put(1, "Joe");
        chainHash.Put(2, "Dino");
        chainHash.Put(3, "Timmy");
        chainHash.Put(4, "Jonathan");
        chainHash.Put(5, "Annie");
        chainHash.Put(6, "Ernie");
        chainHash.Put(7, "Vincent");
        chainHash.Put(8, "Felix");
        chainHash.Put(9, "Sabrina");

        chainHash.About();

        Console.WriteLine("\nGet Joe");
        var temp = chainHash.Get(1);
        Console.WriteLine($" > {temp.Key}: {temp.Value}");

        Console.WriteLine("\nDelete Joe");
        Console.WriteLine(chainHash.Delete(1).Value);

        chainHash.About();
    }
}
