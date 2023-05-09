using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Mark m = new Mark(6, 7);
            m.DoThis();*/

            Mark m2;
            m2.x = 6;
            m2.y = 7;
            m2.DoThis();
        }
    }
    public struct Mark
    {
        public int x;
        public int y;

        public Mark(int a, int b)
        {
            x = a;
            y = b;
        }

        public void DoThis()
        {
            Console.WriteLine(x + y);
        }
    }
}
