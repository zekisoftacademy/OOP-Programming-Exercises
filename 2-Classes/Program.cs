using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person zeki = new Person(); // Örnek Alma İşlemi (Instance)
            zeki.FirstName = "Test";
            zeki.LastName = "SERT";
            Person asel = new Person();
            
            asel.LastName = "SERT";
            Console.WriteLine(zeki.FirstName);
            Console.WriteLine(zeki.LastName);
            Console.WriteLine(zeki.Country);
            Console.WriteLine(zeki.BirthDate);
            Console.WriteLine(asel.FirstName);
            Console.WriteLine(asel.LastName);
            Console.WriteLine(asel.Country);
            Console.ReadLine();
        }
    }
    public class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string Country { get; set; } = "Fransa";
        public Person()
        {
            firstName = "Bilmiyorum";
        }
    }
}