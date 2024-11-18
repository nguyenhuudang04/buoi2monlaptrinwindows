using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>();

            
            students.Add(new student(1, "Đăng",16 ));
            students.Add(new student(2, "An", 22));
            students.Add(new student(3, "Hùng",44));
            students.Add(new student(3, "hải ", 18));
            students.Add(new student(3, "bích",44));

            //a. In danh sách toàn bộ danh sách học sinh
            Console.WriteLine("a. In danh sách toàn bộ danh sách học sinh");
            var evenNumbersQuery = from s in students
                                   select s;

            foreach (var student in evenNumbersQuery)
            {
                student.xuat();
                Console.WriteLine();


            }

            //b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18.
            Console.WriteLine("b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18.");
            var studentsInRange = from s in students
                                  where s.age >= 15 && s.age <= 18
                                  select s;


            foreach (var student in studentsInRange)
            {
                student.xuat();
                Console.WriteLine();

            }


            //c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A".
            Console.WriteLine("c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "); 
            var hsA = from s in students
                      where s.name.StartsWith("A")
                      select s;
            foreach (var student in hsA)
            {
                student.xuat();
                Console.WriteLine();
            }

            //d. Tính tổng tuổi của tất cả học sinh trong danh sách.
            Console.WriteLine("d. Tính tổng tuổi của tất cả học sinh trong danh sách.");
            var tong = (from s in students select s.age).Sum();
            Console.WriteLine($"Tổng tuổi:{tong}");


            //e. Tìm và in ra học sinh có tuổi lớn nhất.

            Console.WriteLine("e. Học sinh có tuổi lớn nhất:");
            int maxage = students.Max(s => s.age);

            var maxtuoi = students.Where(s => s.age == maxage);
       
            foreach (var student in maxtuoi)
            {
                student.xuat();
                Console.WriteLine();
            }


            //f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp.
            Console.WriteLine("f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp.");
            var sapxeptuoi = from s in students 
                              orderby s.age
                              select s;

            foreach (var student in maxtuoi)
            {
                student.xuat();
                Console.WriteLine();
            }
           
            Console.ReadLine();

        }
    }
}
