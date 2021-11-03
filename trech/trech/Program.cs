using System;
using trechLib;

namespace trech
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Trech!");

            // Theoretical implementation
            var universe = new trechLib.System();

            var hydrogenAtom = new trechLib.System();
            hydrogenAtom.Dimensions.AddDimension("system").Value = "atom";
        }
    }
}
