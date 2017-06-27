using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Samochod
    {
        public string marka;
        public string kolor;
        public int przebieg;
        public Samochod(string marka)
        {
            Random rand = new Random();

            if (marka == "Toyota")
            {
                przebieg = 400000;
                kolor = "Srebrny";
            }
            else
            {
                przebieg = 0;
                kolor = "Czarny";
            }

            this.marka = marka;
        }

    }
    public class Motocykl : Samochod
    {
        public Motocykl(string marka) : base(marka)
        {
            Random rand = new Random();
            if (marka == "BMW")
            {
                przebieg = 0;
                kolor = "Ciemno niebieski";
            }
            else
            {
                przebieg = 20;
                kolor = "Czerwony";
            }
            if (marka == "Toyota")
            {
                przebieg = 1000000;
                kolor = "Zielony";
            }

        }
        ~Motocykl()
        { }
    }
    struct Osiagi
    {
        double premax;
        double dostu;
        double hamzestu;

        public Osiagi(string marka)
        {

            premax = 250;
            dostu = 4.3;
            hamzestu = 3.5;
            Console.WriteLine(premax);
            Console.WriteLine(dostu);
            Console.WriteLine(hamzestu);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Samochod auto = new Samochod("Ford"); 
            Samochod sam = new Samochod("Toyota");
            Motocykl mot = new Motocykl("BMW");
            Motocykl mer = new Motocykl("Ford");
            Motocykl toy = new Motocykl("Toyota");

            Console.WriteLine(auto.marka);
            Console.WriteLine(auto.kolor);
            Console.WriteLine(auto.przebieg);
            Console.WriteLine(sam.marka);
            Console.WriteLine(sam.kolor);
            Console.WriteLine(sam.przebieg);
            Console.WriteLine(mot.marka);
            Console.WriteLine(mot.kolor);
            Console.WriteLine(mot.przebieg);
            Console.WriteLine(mer.marka);
            Console.WriteLine(mer.kolor);
            Console.WriteLine(mer.przebieg);
            Console.WriteLine(toy.marka);
            Console.WriteLine(toy.kolor);
            Console.WriteLine(toy.przebieg);
            Osiagi de = new Osiagi("BMW");

            FileStream fw;
            FileStream fr;
            fw = new FileStream(@"..\Samochod", FileMode.OpenOrCreate, FileAccess.Write);
            try
            {
                StreamWriter sw = new StreamWriter(fw);

                sw.WriteLine("Auta");
                sw.WriteLine("Marka: " + auto.marka);
                sw.WriteLine("Kolor: " + auto.kolor);
                sw.WriteLine("Przebieg: " + auto.przebieg);
                sw.WriteLine("Marka: " + sam.marka);
                sw.WriteLine("Kolor: " + sam.kolor);
                sw.WriteLine("Przebieg: " + sam.przebieg);
                sw.WriteLine("Marka: " + mot.marka);
                sw.WriteLine("Kolor: " + mot.kolor);
                sw.WriteLine("Przebieg: " + mot.przebieg);
                sw.WriteLine("Marka: " + mer.marka);
                sw.WriteLine("Kolor: " + mer.kolor);
                sw.WriteLine("Przebieg: " + mer.przebieg);
                sw.WriteLine("Marka: " + toy.marka);
                sw.WriteLine("Kolor: " + toy.kolor);
                sw.WriteLine("Przebieg: " + toy.przebieg);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            fw.Close();
            
            fr = new FileStream(@"..\Samochod", FileMode.Open, FileAccess.Read);
            try
            {
                StreamReader sr = new StreamReader(fr);

                Console.WriteLine(sr.ReadToEnd());

            }
            finally { }
            fr.Close();
            Console.ReadLine();
        }

    }
    
}
