using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQEg
{
    class Studentclient
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Ram", 89, DateTime.Now, "Chennai"));
            students.Add(new Student(2, "Ramu", 82, DateTime.Now, "Bangalore"));
            students.Add(new Student(3, "Ramesh", 99, DateTime.Now, "Puna"));
            students.Add(new Student(4, "Ranga", 77, DateTime.Now, "Chennai"));
            students.Add(new Student(5, "Ramba", 49, DateTime.Now, "Bangalore"));
            students.Add(new Student(6, "Rathna", 85, DateTime.Now, "Puna"));

            Console.WriteLine("Enter the city to be searched");
            string searchcity = Console.ReadLine();
            var result = (from i in students
                          where i.Mark > 50
                          && i.StudentCity == searchcity
                          select i).ToList();
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

        }
    }
}