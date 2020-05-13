using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismInterface
{
    class Canon : Printerw
    {
        public void Show()
        {
            Console.WriteLine("Printer Canon dimension: 9.5 * 12");
        }

        public void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }
}
