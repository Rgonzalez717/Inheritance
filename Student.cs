using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    public class Student 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentId { get; set; }
        public string Email { get; set; }
        
        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0} and age : {1} ID : {2} Email : {3} ", Name, Age, StudentId, Email);
        }

        public Student(string Name, int Age, string StudentID, string Email)
        {
            this.Name = Name;
            this.Age = Age;
            this.StudentId = StudentId;
            this.Email= Email;
        }
    }
}
