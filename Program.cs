using System;

namespace Test02_LageEnClassOgEndre
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingred = new Ingrediens(30, "dl");

            Console.WriteLine(ingred.GetDescription());
        }
    }
}
