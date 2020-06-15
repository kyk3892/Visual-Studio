using System;

namespace SumUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animal = { "Cat", "Dog", "Horse" };
            string animals = string.Join(":", animal);
            Console.WriteLine(animals);
            string animalsUp = animals.ToUpper();
            Console.WriteLine(animalsUp);
            string[] str = animalsUp.Split(":");
            foreach(var item in str) { Console.WriteLine(item); }
        }
    }
}
