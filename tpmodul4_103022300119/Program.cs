using System;
using tpmodul4_103022300119;

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();

        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        Console.WriteLine("Kode Pos: " + kodePos.GetKodePos(kelurahan));
    }
}
