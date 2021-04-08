using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_therd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввпедите 3 числа, что бы узнать их среднее: ");
            
            float first = int.Parse(Console.ReadLine()); 
            float second = int.Parse(Console.ReadLine()); 
            float third = int.Parse(Console.ReadLine());

            float firstAction = first / 3;
            float secondAction = firstAction + second;
            float thirdAcrion = secondAction + third;


            Console.WriteLine(thirdAcrion);

            Console.ReadKey();

        }
    }
}
