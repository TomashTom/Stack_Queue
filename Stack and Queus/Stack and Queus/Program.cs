using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
namespace CSharpTutorial
{
    class Program
    {
        public static void Main()
        {
            List<string> cars = new List<string> {
                "Honda", "Mercedez", "BMW"
            }
            ;
            cars.Add("Suzuki");
            cars.AddRange(new[] {
                "Ford", "Audi", "Cameri"
            }
            );
            cars.Insert(0, "Toyota");
            cars.InsertRange(0, new[] {
                "Cuore", "Lexus", "Safari"
            }
            );
            IEnumerator enumer = cars.GetEnumerator();
            int i = 0;
            while (enumer.MoveNext())
            {
                i++;
                Console.WriteLine(i + "-" + enumer.Current);
            }
            cars.Remove("Audi");  //Saliname audi is savo saraso o veliaus salinam visus kurie prasideda raide(c)
            cars.RemoveAt(2);
            cars.RemoveRange(0, 2);
            cars.RemoveAll(c => c.StartsWith("c", true, System.Globalization.CultureInfo.InvariantCulture));
            i = 0;
            enumer = cars.GetEnumerator();
            Console.WriteLine("\n*****************\n");
            while (enumer.MoveNext())
            {
                i++;
                Console.WriteLine(i + "-" + enumer.Current);
            }
            Console.WriteLine("\n*****************\n");
            Console.WriteLine(cars[4]);
            Console.WriteLine(cars[cars.Count - 1]);
            List<string> carsubset = cars.GetRange(0, 3);
            string[] cararray = cars.ToArray();
            i = 0;
            Console.WriteLine("\n*****************\n");
            foreach (string car in cararray)
            {
                i++;
                Console.WriteLine(i + "-" + car);
            }
            Console.ReadLine();
        }
    }
}

//Po iteracijų matome kad kaip galime gauti elementą pagal indeksą.
//Matome tai padarėme šiose eilutėse, kur atspausdinome elementą pagal indeksą.