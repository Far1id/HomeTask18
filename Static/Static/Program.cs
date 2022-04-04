using System;
using ClassLibrary;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullname;
            string groupNo;
            byte age;
            do
            {
                Console.WriteLine("telebenin adi ve soyadini daxil edin: ");
                fullname = Console.ReadLine();
            } while (!Student.CheckFullname(fullname));

            do
            {
                Console.WriteLine("telebenin qrup nomresini daxil edin: ");
                groupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(groupNo));

            Console.WriteLine("telebenin yasini daxil edin: ");
            age = Convert.ToByte(Console.ReadLine());

            Student student = new Student( groupNo);
            student.Age = age;
            student.Fullname = fullname;

            Console.WriteLine(student.Age);
            Console.WriteLine(student.Fullname);
            Console.WriteLine(student.GroupNo);
        }
    }
}
