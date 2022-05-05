using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Laptop
    {
        private string name;
        private string producer;
        private float price;

        public Laptop() : this("Inspiron 15", "DELL", (float)20000.0)
        {
        }
        public Laptop(string name, string producer, float price)
        {
            this.name = name;
            this.producer = producer;   
            this.price = price; 
        }

        public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }   
        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                producer = value;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
                  
    }

    public class Shop
    {
        private string name;
        private Laptop[] Laptops;

        public Shop() : this("MegaMax")
        {
        }
        public Shop(string name, params Laptop[] count)
        {
            this.name = name;
            Laptops = new Laptop[count.Length];
            for (int i = 0; i < count.Length; i++)
            {
                Laptops[i] = count[i];
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Size
        {
            get
            {
                return Laptops.Length;
            }
        }
        public Laptop this[int index]
        {
            get
            {
                return Laptops[index];
            }
            set
            {
                Laptops[index] = value;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop l1 = new Laptop();
            Laptop l2 = new Laptop("Nitro 5", "ACER", 18000);
            Laptop l3 = new Laptop("MacBook pro 16", "APPLE", 48000);
            Shop s = new Shop("Fenix", l1, l2, l3);
            Console.WriteLine("Мазазин: {0}\n", s.Name);            
            for (int i = 0; i < s.Size; i++)
            {
                Console.WriteLine($"{s[i].Name} - {s[i].Producer} - {s[i].Price}\n");
            }            
            Console.ReadKey();
        }
    }
}
