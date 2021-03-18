using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(2,2);
            Vector b = new Vector(2, 2);
            Vector c = new Vector(0, 0);
            Console.WriteLine(vector.ToString());
            vector += b;
            Console.WriteLine(vector.ToString());
            //vector -= b;
            //Console.WriteLine(vector.ToString());
            Console.WriteLine();
            vector *= b;
            
            Console.WriteLine(b.ToString());
            


        }
    }
}
