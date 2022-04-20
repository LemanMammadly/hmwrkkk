using homework0.Models;
using System;

namespace homework0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad soyad daxil edin: ");
            string fullname = Console.ReadLine();
            Console.WriteLine("Group no daxil edin: ");
            string groupno=Console.ReadLine();
            Student student = new Student(groupno,fullname);
        }
    }
}
