using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine line = new HorizontalLine(1, 15, 5, '#');
            line.Draw();

            VerticalLine Vline = new VerticalLine(1, 15, 0, '%');
            Vline.Draw();

            Console.ReadLine();      
         }
    }
}
