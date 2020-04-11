using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("darmono", 153);
            person.GetNameAndAge();
           Teacher teacher = new Teacher("mardi", 281 , "19702001", "Web");
           teacher.GetNameAndAge();
           Student student = new Student("sutiyani", 81 ,"19112008", "yani@google.com");
            student.GetNameAndAge();



            Console.ReadKey();
        }
    }
}
