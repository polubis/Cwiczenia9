using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,Osoba> Slownik=new Dictionary<int,Osoba>();
            Slownik.Add(1 ,new Osoba ("Piotr", "Jarek"));
            Slownik.Add(2, new Osoba("Tomek", "Piotrowicz"));
            Slownik.Add(3, new Osoba("Mirek", "Janek"));
            foreach(var element in Slownik)
            {
                Console.WriteLine(element.Key+"."+element.Value.returnImie()+" "+element.Value.returnNazwisko());
            }
            //Slownik.Clear()// Czysci wszystko
            Console.WriteLine(Slownik.ContainsKey(2));
            Osoba osoba1 = new Osoba();
            var element1 = (Osoba) Slownik[1];
            Slownik.Remove(1);
            string Value = Slownik[2].returnImie();
            Console.WriteLine(Value);
            Queue<string> kolejka = new Queue<string>();
            kolejka.Enqueue("DDSDsdsd");
            kolejka.Enqueue("ww");
            kolejka.Enqueue("asdad");
            kolejka.Enqueue("ddasdasd");
            kolejka.Enqueue("asdfasdasd");
            kolejka.Dequeue();
            Console.WriteLine(kolejka.Peek());
            foreach (var element in kolejka)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            SortedSet<string> posort = new SortedSet<string>(kolejka);  //1 sposob
            foreach (var element in posort)
            {
                Console.WriteLine(element);
            }
            //2 sposob Lingq
            /*
            var sort = kolejka.OrderBy(x => x);
            Console.WriteLine(sort.GetType());
            foreach(var element in sort)
            {
                Console.WriteLine(element);
            }
             */
            SortedList<string, int> ListaOsob = new SortedList<string, int>();
            ListaOsob.Add("pawel", 14);
            ListaOsob.Add("jarek", 12);
            ListaOsob.Add("tomasz", 13);
            ListaOsob.Add("anton", 15);
            ListaOsob.Add("pawel1", 13);
            foreach (var element in ListaOsob)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(ListaOsob.ContainsKey("pawel"));
            ListaOsob.Remove("pawel");
            foreach (var element in ListaOsob)
            {
                Console.WriteLine(element);
            }


       
            Console.ReadKey();
        }
    }
}
