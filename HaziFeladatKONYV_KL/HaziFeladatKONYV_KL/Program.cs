using System;

namespace HaziFeladatKONYV_KL 
{
    public class Konyv
    {
        public string Cim { get; set; }
        public string Szerzo { get; set; }
        public int Oldalszam { get; set; }
        public int Ar { get; set; }

        public Konyv(string cim, string szerzo, int oldalszam, int ar)
        {
            Cim = cim;
            Szerzo = szerzo;
            Oldalszam = oldalszam;
            Ar = ar;
        }


        public Konyv(string cim, string szerzo, int oldalszam): this(cim, szerzo, oldalszam, 3000) //Ez a sor  GPT mert nem tudtam és nem találtam meg az interneten
        {
        }

        public override  string ToString()
        {
            return $"Cím: {Cim}, Szerző: {Szerzo}, Oldalszám: {Oldalszam}, Ár: {Ar}";
        }

        public bool vastagE()
        {
            if (Oldalszam>500) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool dragaE()
        {
            if (Ar>5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg hány könyvet szeretnél megadni:");
            int n = int.Parse(Console.ReadLine());
            Konyv[] Konyvek = new Konyv[n];
            for (int i = 0; i < Konyvek.Length; i++)
            {
                Console.WriteLine($"Add meg a(z) {i + 1}. könyv  címet:");
                string cim = Console.ReadLine();

                Console.WriteLine($"Add meg a(z) {i + 1}. könyv  Szerzőjét:");
                string szerzo = Console.ReadLine();

                Console.WriteLine($"Add meg a(z) {i + 1}. könyv  oldalszámát:");
                int oldalszam = int.Parse(Console.ReadLine());

                Console.WriteLine($"Add meg a(z) {i + 1}. könyv árát (vagy nem):\n");
                string ar = Console.ReadLine();

                if (string.IsNullOrEmpty(ar))
                {
                    Konyvek[i] = new  Konyv(cim, szerzo, oldalszam);
                }
                else
                {
                    int ujAr = int.Parse(ar);
                    Konyvek[i] = new Konyv(cim, szerzo, oldalszam, ujAr);
                }
            }

            foreach (var konyv in Konyvek)
            {
                Console.WriteLine(konyv.ToString());
                Console.WriteLine($"A könyv vastag-e: {konyv.vastagE()}");
                Console.WriteLine($"A könyv drága(5000ft-nál drágább): {konyv.dragaE()}\n");


            }
        }
    }
}