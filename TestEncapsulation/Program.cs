using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEncapsulation
{
    //INTRODUCTION
    //An encapsulated object is often called an abstract data type
    //NEED FOR ENCAPSULATION
    //The need of encapsulation is to protect or prevent the code(data) from accidental corruption 
    //due to the silly little errors that we are all prone to make.

    class Program
    {
        static void Main(string[] args)
        {
            ENCAPSULATION_USING_ACCESSORS_AND_MUTATORS();

            
            Console.WriteLine("..........");
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }

        static void ENCAPSULATION_USING_ACCESSORS_AND_MUTATORS()
        {
            Department d = new Department();
            d.SetDepartname("ELECTRONICS");
            Console.WriteLine("The Department is : " + d.GetDepartname());
        }

        static void ENCAPSULATION_USING_PROPERTIES()
        {
            Department d = new Department();
            d.Departname = "Communication";
            Console.WriteLine("The Department is :{0}", d.Departname);
        }

        static void READ_ONLY_PROPERTY()
        {
            Department d = new Department("CSE001");
            //d.DepartCode = "physics"; // can't write to this property
            Console.WriteLine("The Department is: {0}", d.Departname);
        }

        static void WRITE_ONLY_PROPERTY()
        {
            Department d = new Department();
            d.FacultyName = "COMPUTERSCIENCE";
            //Console.WriteLine("The Faculty is: {0}", d.FacultyName); // can't read the property
        }

        

    }
}
