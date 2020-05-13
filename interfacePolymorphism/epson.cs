using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismInterface
{
    class Epson : Printerw
    {
        public void Show()
        {
            Console.WriteLine("Printer Epson dimension: 10 * 11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
    }
}
