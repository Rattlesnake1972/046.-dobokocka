using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046.dobokocka
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Leírás

            Console.WriteLine("Ez a program dobókocka dobálást szimulál és statisztikát készít belőle.");
            Console.WriteLine("A folytatáshoz nyomj entert!");
            Console.ReadLine();
            Console.Clear();

            #endregion Dobásszám bekérése

            Console.Write("Add meg a dobások számát! ");
            int dobasszam = Convert.ToInt32(Console.ReadLine());

            //#endregion
            #region Egyéb változók létrehozása

            // Dobások száma adott értékre ezekben a változókban lesznek letárolva.

            int egyesek_szama = 0;
            int kettesek_szama = 0; 
            int harmasok_szama = 0;
            int negyesek_szama = 0;
            int otosok_szama = 0;
            int hatosok_szama = 0;

            #endregion
            #region Dobások legenerálása, kiírása

            Random randomszam = new Random();

            // Létrehozom a tömböt, melyben letárolom az eredményeket.

            int[] dobasok = new int[dobasszam];

            for (int i = 0; i < dobasszam; i++)
            {
                dobasok[i] = randomszam.Next(1, 7);
                Console.WriteLine("{0}. dobás:{1}", i+1, dobasok[i]);
                System.Threading.Thread.Sleep(200);

            }

            Console.WriteLine("A statisztikához nyomj entert!");
            Console.ReadLine();
            Console.Clear();

            #endregion
            #region Statisztika készítése

            for (int i = 0; i < dobasszam; i++)
            {
                if(dobasok[i] == 1)
                {
                    egyesek_szama++;
                }

                else if (dobasok[i] ==2)
                {
                    kettesek_szama++;
                }

                else if (dobasok[i] == 3)
                {
                    harmasok_szama++;
                }

                else if (dobasok[i] == 4)
                {
                    negyesek_szama++;
                }

                else if (dobasok[i] == 5)
                {
                    otosok_szama++;
                }

                else 
                {
                    //Console.WriteLine("Hatost dobtál, vége a játéknak.");
                    hatosok_szama++;
                }

            }

            #endregion
            #region Statisztika kiíratása

            Console.WriteLine("Statisztika:");

            Console.WriteLine("Egyes: {0}\nKettes: {1}\nHármas: {2}\nNégyes: {3}\nÖtös: {4}\nHatos: {5}", egyesek_szama, kettesek_szama, harmasok_szama, negyesek_szama, otosok_szama, hatosok_szama);

            #endregion

            Console.ReadLine();

        }
    }
}
