using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    public class Teacher 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0} and age : {1} ID : {2} subject : {3} ", Name, Age, TeacherId, Subject);
        }

        public Teacher(string Name, int Age, string TeacherId, string Subject)
        {
            this.Name = Name;
            this.Age = Age;
            this.TeacherId = TeacherId;
            this.Subject = Subject;
        }
    }
}
