using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    interface IPaper1
    {
        int Size { get; set; }
        void NewsPaper();
    }
    interface IPaper2
    {
        int Age { get; set; }
        void News();
    }

    public class Book:IPaper1,IPaper2
    {
        public int Size { get; set; }
        public int Age
        {
            set
            {
                if (value > 10)
                {
                    Console.WriteLine("old");
                }
                else
                {
                    Console.WriteLine(" new");
                }

            }
            get
            {
                { return Age; }
            }
        }


            public void News()
        {
            Console.WriteLine($"this{Age} size is {Size}");
        }
        public void NewsPaper()
        {
            Console.WriteLine("Finito");

        }
    }
    interface IPen
    {
        string Colar { get; set; }
        bool Open();
        bool Close();
        void Write();
    }
    public class Parker : IPen
    {
        public string Colar { get; set; }
        public bool Open()
        {
            return true;
        }
        public bool Close()
        {
            return false;
        }
        public void Write()
        {
            Console.WriteLine($"This pan is {Colar} ");
        }
    }
    public class Flom : IPen 
    {
        public string Colar { get; set; }
        public bool Open()
        {
            return true;
        }
        public bool Close()
        {
            return false;
        }
        public void Write()
        {
            Console.WriteLine($"Perfect drowing flom of {Colar}");
        }
            
    }
        
    public class Program
    {
        
            
        static void Main(string[] args)
        {

            Book book = new Book();
            book.Size = 50;
            Console.WriteLine("Book age ?");
            book.Age = Convert.ToInt32(Console.ReadLine());
            book.News();
            book.NewsPaper();
            Flom f = new Flom();
            Parker p = new Parker();
            f.Colar = "Red";
            f.Write();
            p.Colar = "blue";
            p.Write();
            p.Open();
            Console.ReadKey();
        }
    }
}
        
    

