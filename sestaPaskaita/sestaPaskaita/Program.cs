using System;

namespace sestaPaskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Work in gitHub!");
            double earthArea;
            double earthVolume = 0;
            double triangleLine = 0;

            
            double r = 6371;
            earthArea = 4 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Earth surface area = {earthArea}");
           
            earthVolume = 4/3*Math.PI*Math.Pow(r, 3);
            Console.WriteLine($"Earth volume: {earthVolume}");

            Console.WriteLine("**********************");
            Console.WriteLine("*Viso kintamųjų: 3");
            Console.WriteLine($"*Kintamasis1: {earthArea}");
            Console.WriteLine($"*Kintamasis2: {earthVolume}");
            Console.WriteLine($"*Kintamasis3: {triangleLine}");
            Console.WriteLine($"*Suma: {earthArea + earthVolume + triangleLine}");
            Console.WriteLine($"*Vidurkis: {(earthArea + earthVolume + triangleLine)/3}");
            Console.WriteLine("**********************");


        }
    }
}
