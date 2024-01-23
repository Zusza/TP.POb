using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_16_01_2024_2 classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ArthurMorgan = new Person();
            ArthurMorgan.SetFirstName("Arthur");
            Conosle.WriteLine("Imię: " + ArthurMorgan.FirstName);
            ArthurMorgan.LastName = "Morgan";
            Conosle.WriteLine("Nazwisko: " + ArthurMorgan.LastName());

            Student s1 = new Student();
            s1.StudentNumber = "1855";
            Console.WriteLine("Numer indeksu studenta: " + s1.StudentNumber);

            Teacher t1 = new Teacher();
            t1 Subjects = new List<string> {"Math", "IT", "History"};
            Console.WriteLine(t1.GetSubjects());
            //foreach (var subject in t1.Subjects) //Wyświetlanie v1
            //{
            //     Console.WriteLine(subject);
            //}
            //Console.WriteLine(string.Join(", ", t1.Subjects)); //Wyświetlanie v2

            ArthurMorgan Adress = new Adress();
            ArthurMorgan.Adress.City = "Blackwater";
            ArthurMorgan.Adress.Street = "Lumbago";
            ArthurMorgan.Adress.HouseNumber = "3/6";
            ArthurMorgan.Adress.PosterCode = "26-036";
            Conosle.WriteLine(ArthurMorgan.Adress.GetAdress());

            ArthurMorgan.DateOfBirth = DateTime.Now;
            Console.WriteLine("Data i czas: {0}", ArthurMorgan.DateOfBirth); //Data i czas: 23.01.2024 12:08:11
            
            ArthurMorgan.DateOfBirth = DateTime();
            Console.WriteLine("Data i czas: {0}", ArthurMorgan.DateOfBirth); //Data i czas: 01.01.0001 00:00:00
            
            ArthurMorgan.DateOfBirth = DateTime(2000, 3, 29);
            Console.WriteLine("Data: {0}", ArthurMorgan.DateOfBirth.ToShortDateString); //Data: 29.03.2000
            
            ArthurMorgan.DateOfBirth = DateTime(2000, 3, 29, 12, 13, 36);
            Console.WriteLine("Czas: {0}", ArthurMorgan.DateOfBirth.ToShortTimeString); //Czas: 12.13
            
            ArthurMorgan.DateOfBirth = DateTime(2000, 3, 29, 12, 13, 36);
            Console.WriteLine("Czas: {0}", ArthurMorgan.DateOfBirth.ToLongTimeString); //Czas: 12.13.26
            
            ArthurMorgan.DateOfBirth = DateTime(2000, 3, 29, 12, 13, 36);
            Console.WriteLine("Czas: {0}", ArthurMorgan.DateOfBirth.ToLongDateString); //Data i dzień tygodnia: Wtorek, 29.03.2000
            
            Conosle.ReadKey();
        }
    }
}
---------------------------------------------Class.1-------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_16_01_2024_2 classes
{
    internal class Program
    {
        class Person
        {
            public string FirstName { get; private set; }
            public string LastName { private get; set; }
            public float Height { get; set; }
            public float Weight { get; set; }
            public Adress Adress {get; set;}
            public DateTime DateOfBirth {get; set;}

            public void SetFirstName(string name)
            {
              FirstName = name;
            }

            public string GetLastName()
            {
              return LastName;
            }
        }
---------------------------------------------Class.2-------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_16_01_2024_2 classes
{
    internal class Student
    {
        public string StudentNumber {get; set;}
    }
}

--------------------------------------------Class.3-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_16_01_2024_2 classes
{
    internal class Teacher
    {
        public List<string> Subjects {private get; set;}
        public string GetSubjects()
        {
            return string.Join(", ", Subjects); 
        }
    }
}
--------------------------------------------Class.4-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_16_01_2024_2 classes
{
    internal class Adress
    {
            public string City { get; set; }
            public string Street {get; set; }
            public float HouseNumber { get; set; }
            public float PostalCode { get; set; }

            public string GetAdress
            {
                return $"Miasto: {City}, ulica: {Street} {HouseNumber}, kod pocztowy: {PostalCode}";
            }
    }
}
