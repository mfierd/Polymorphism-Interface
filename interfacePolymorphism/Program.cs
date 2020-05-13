using System;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");
            Console.Write("Nomor Printer [1 ... 3] : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Printerw printer = new printer();

            if (pilihPrinter > 0 && pilihPrinter < 4)
            {
                if (pilihPrinter == 1)
                {
                    printer = new Epson();
                }
                else if (pilihPrinter == 2)
                {
                    printer = new Canon();
                }
                else
                {
                    printer = new LaserJet();
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid \n");
            }

            printer.Show();
            printer.Print();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nama\t: Muh. Firdaus F.");
            Console.WriteLine("NIM\t: 19.11.2789");
            Console.WriteLine("Kelas\t: IF03");

            Console.ReadKey();
        }
    }
}
