using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KSR_WCF2;

namespace Klient1
{
    public class Task1Client
    {
        public static void Main(string[] args)
        {
            var zadanie1 = new ServiceReference1.Zadanie1Client();

            zadanie1.DlugieObliczeniaAsync();

            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(zadanie1.Szybciej(i, 3 * i * i - 2 * i));
            }

            ((IDisposable)zadanie1).Dispose();
        }
    }
}