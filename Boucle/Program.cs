using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle
{
    class Program
    {
        static void Main(string[] args)
        {
            // exos cours
            //ExCalc();
            //ExMoy();
            //Console.WriteLine("Perimètre (2) = " + ExPer(2));
            //Console.WriteLine("Surface (2) = " + ExSurf(2));
            //Console.WriteLine("Déplacement (abcdefghijklmnopqrstuvwxyz) = " + ExDepl("abcdefghijklmnopqrstuvwxyz"));

            Console.WriteLine("Test 1 (multiples de 2) :");
            ExMult();

            Console.WriteLine("Test 2 (sommes des chiffres jusqu'à X) :");
            ExCalcul(7);

            Console.WriteLine("Test 3 (moyenne de 5 nombres) :");
            //ExMoyenne();

            Console.WriteLine("Test 4 (sommes des nombres) :");
            CalculSommeEntiers(1,10);
            CalculSommeEntiers(1,100);

            Console.WriteLine("Test 5 (moyenne d'une liste) :");
            CalculMoyenne(new List<double>{ 1.0,5.5,9.9,2.8,9.6});

            Console.WriteLine("Test 6 (Listes) :");
            CalculListes(); 
        }

        private static void CalculListes()
        {
            List<int> list3 = new List<int>();
            List<int> list5 = new List<int>();
            int somme = 0;
            bool find = true;
            for(int i=1; i<=100;i++)
            {
                if (i % 3 == 0) { list3.Add(i); }
                if (i % 5 == 0) { list5.Add(i); }
                if (i % 3 == 0 && i % 5 == 0) { somme += 2 * i; }
            }
            Console.WriteLine("La somme est égale à " + somme);
        }

        private static void CalculMoyenne(List<double> list)
        {
            Console.Write("La moyenne de la liste ");
            foreach(double nombre in list)
            {
                Console.Write(nombre + " ");
            }
            Console.WriteLine("est " + list.Average());
        }

        private static void CalculSommeEntiers(int v1, int v2)
        {
            int deb = (v1 <= v2) ? v1 : v2;
            int fin = (v1 >= v2) ? v1 : v2;
            int somme = 0;
            for (int i=deb; i <= fin; i++ )
            {
                somme += i;
            }
            Console.WriteLine("La somme des nombres entre " + deb + " et " + fin + " est " + somme);
        }

        private static void ExMoyenne()
        {
            double[] listeNombres = new double[5];
            for(int i=5; i>0; i--)
            {
                Console.WriteLine("Encore " + i + " nombres à rentrer :");
                listeNombres[i-1] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Moyenne des 5 nombres : " + listeNombres.Average());
        }

        private static void ExCalcul(int valeur)
        {
            int somme = 0;
            for (int i = 0; i <= valeur; i++)
            {
                somme += i;
            }
            Console.WriteLine("Somme jusqu'à " + valeur.ToString() + " = " + somme.ToString());
        }

        static void ExCalc()
        {
            Double somme = 12 + 5 * 12.5 - 1253.68;
            Console.WriteLine("Total = " + somme);
        }

        static void ExMoy()
        {
            Double moy = (1.0 + 5.5 + 9.9 + 2.8 + 9.6) / 5;
            Console.WriteLine("Moyenne = " + moy);
        }

        static double ExPer(double rayon)
        {
            Double per = 2 * Math.PI * rayon;
            return per;
        }

        static double ExSurf(double rayon)
        {
            Double surf = Math.PI * Math.Sqrt(rayon);
            return surf;
        }

        static string ExDepl(String deb)
        {
            int test = deb[1];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < deb.Length; i++)
            {
                if (deb[i] >= 123 - 3)
                {
                    sb.Append(Convert.ToChar(deb[i] - 26 + 3));
                }
                else
                {
                    sb.Append(Convert.ToChar(deb[i] + 3));
                }

            }
            String fin = sb.ToString();
            return fin;
        }

        static void ExMult()
        {
            Console.Write("Multiple de 20 : ");
            for (int i = 0; i <= 20; i = i + 2)
            {
                Console.Write(i + "-");
            }
            Console.WriteLine();
        }
    }
}