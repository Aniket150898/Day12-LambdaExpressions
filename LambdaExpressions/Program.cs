using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Problems on Lambda Expression");
            //Console.ReadLine();
            Console.WriteLine("Select any one option \n 1. add data to add Student");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    List<Student> students = new List<Student>();

                    students.Add(new Student { Id = 1, Name = "Aniket", PhoneNumber = 83606543222, Address = "Mumbai", Age = 24 });
                    students.Add(new Student { Id = 2, Name = "Skyop", PhoneNumber = 98705454042, Address = "Pune", Age = 21 });
                    students.Add(new Student { Id = 3, Name = "Zombie", PhoneNumber = 9898456512, Address = "Nagpur", Age = 17 });
                    students.Add(new Student { Id = 4, Name = "Sonic", PhoneNumber = 86782224562, Address = "Sindhurg", Age = 36 });
                    students.Add(new Student { Id = 5, Name = "Happy", PhoneNumber = 8889225913, Address = "Jalgaon", Age = 15 });

                    foreach (Student student in students)
                    {
                        Console.WriteLine("ID: " + student.Id);
                        Console.WriteLine("Name: " + student.Name);
                        Console.WriteLine("Phone Number: " + student.PhoneNumber);
                        Console.WriteLine("Address: " + student.Address);
                        Console.WriteLine("Age: " + student.Age);
                        Console.ReadLine(); 
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
