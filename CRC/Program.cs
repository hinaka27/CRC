using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRC
{
    class Program
    {
        static void Main(string[] args)
        {

            int slowo = 108402;
            int dzielnik = 11;
            int dlugoscSlowa = 17;
            int n = 3;
            int szukanie;
            int reszta;
            int porownanie;
            Console.WriteLine(slowo << n);
            slowo = slowo << n;
            int czy1;
            while (dlugoscSlowa > 1)
            {
                szukanie = (1 << (dlugoscSlowa + n));
                czy1 = (slowo & szukanie);
                if (czy1 == 0)
                {

                    reszta = ((slowo) ^ dzielnik << dlugoscSlowa - 1);
                    //Console.Write("slowo porownaniu:");
                    Console.WriteLine(reszta);
                    //Console.Write("wynik porownania:");
                    porownanie = ((slowo >> dlugoscSlowa - 1) ^ dzielnik);
                    //Console.WriteLine(porownanie);
                    if (porownanie < 8 && dlugoscSlowa > 1)
                    {
                      //  Console.WriteLine("przesunieto bit bo reszta jest mniejsza niz 8");                       
                        dlugoscSlowa--;
                        if (porownanie<4 && dlugoscSlowa > 1)
                        {
                          //  Console.WriteLine("przesunieto bit bo reszta jest mniejsza niz 4");
                            dlugoscSlowa--;
                            if(porownanie < 2 && dlugoscSlowa > 1)
                            {
                               // Console.WriteLine("przesunieto bit bo reszta jest mniejsza niz 2");
                                dlugoscSlowa--;
                                if(porownanie < 1 && dlugoscSlowa > 1)
                                {
                                   // Console.WriteLine("przesunieto bit bo reszta jest mniejsza niz 1");
                                    dlugoscSlowa--;
                                }
                            }
                        }

                    }
                    slowo = reszta;
                }
                else
                {
                    dlugoscSlowa--;
                    slowo = slowo >> 1;
                    
                   // Console.WriteLine("przesunieto bit bo 0 na poczatku");
                }
               // Console.WriteLine("dlugosc_slowa: " + dlugoscSlowa);
                Console.ReadKey();
            }
            Console.WriteLine("CRC: " + slowo);
            Console.ReadKey();
        }
    }
}
