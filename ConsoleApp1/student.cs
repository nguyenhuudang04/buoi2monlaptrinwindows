using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class student
    {
        public int id {  get; set; }
        public string name { get; set; }
       public int   age { get; set; }
        public student(int id,string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age  =age ;
        }


        public void xuat()
        {
            Console.WriteLine("ma la "+id);
            Console.WriteLine("ten la {0}",name);
            Console.WriteLine("tuoi la {0}",age );
        }
    }
}
