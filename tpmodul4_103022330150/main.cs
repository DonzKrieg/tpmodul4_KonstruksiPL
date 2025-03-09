using System;

namespace tpmodul4_103022330150
{
    class Program
    {
        static void Main()
        {
            KodePos kodePos = new KodePos();

            Console.WriteLine("Daftar Kelurahan dan Kode Pos:");

            foreach (string kelurahan in new string[]
            {
                "Batununggal", "Kujangsari", "Mengger", "Wates",
                "Cijagra", "Jatisari", "Margasari", "Sekejati",
                "Kebonwaru", "Maleer", "Samoja"
            })
            {
                Console.WriteLine($"{kelurahan}: {kodePos.GetKodePos(kelurahan)}");
            }
        }
    }
}
