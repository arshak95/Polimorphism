using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    abstract class Teacher
    {
        private string _person1;
        public string Person1
        {
            get { return _person1; }
            set { _person1 = value; }
        }
        public Teacher(string _person1)
        {
            this.Person1 = _person1;
        }
        public virtual void TeachersPostion()
        {
            Console.WriteLine($"Name is : {Person1}");

        }

    }
     class School : Teacher
    {
        public string Profetion { get; set; }
        public int TeachersMoney { get; set; }
        public School(string _person1, string profetion, int teachersmoney): base(_person1)
        {
            Profetion = profetion;
            TeachersMoney = teachersmoney;
        }
        public override void TeachersPostion()
        {
            Console.WriteLine($"teacher name is: {Person1} hi is spetiolist of {Profetion} ");
            if  (TeachersMoney >= 150000)
            {
                Console.WriteLine($"{Person1} is working ");
            }
                
                
                 
        }
    }
    public class Bank
    {
        public int Money { get; set; }
        public int StudentMoney { get; set; }
        public virtual void Cash()
        {

        }

    }
    public class Student :Bank
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age { get; set; }
        public Student(string name, int age)

        {
            this.Name = name;
            this.Age = age;
        }
       

        public void GoingToSchoolByCar()
        {
           
            
            
            if (StudentMoney > 50000)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("i have money and i going to school");
                    System.Threading.Thread.Sleep(1000);
                    if (i == 5)
                    {
                       
                        Console.WriteLine("i have no money");
                    }
                }
                Console.WriteLine("Take money from Bank");
            }
            

        }
        public  void Cash()
        {
            

            if (Money > 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Sharunakum enq gnal dasi ");
                    System.Threading.Thread.Sleep(1000);
                }
            }

        }

    } 
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new School("Arshak", "History", 200000);
            teacher.TeachersPostion();
            Student student = new Student("Albert",24);
            student.StudentMoney = (60000);
            student.GoingToSchoolByCar();
            Bank bank = new Bank();
            Console.WriteLine("Banki qanaky asa");
            bank.Money = Convert.ToInt32 (Console.ReadLine());
            bank.Cash();
            if (bank.Money > 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Sharunakum enq gnal dasi ");
                    System.Threading.Thread.Sleep(1000);
                }
            }

        }
    }
}
