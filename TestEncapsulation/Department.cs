using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEncapsulation
{
    class Department
    {
        public Department() // default contructor
        {
            
        }

        //ENCAPSULATION USING ACCESSORS AND MUTATORS
        private string deptName;

        // Accessor.  
        public string GetDepartname()
        {
            return deptName;
        }

        // Mutator.  
        public void SetDepartname(string a)
        {
            deptName = a;
        }


        //ENCAPSULATION USING PROPERTIES
        public string Departname
        {
            get
            {
                return deptName;
            }
            set
            {
                deptName = value;
            }
        }

        //READ ONLY PROPERTY
        public Department(string avalue)
        {
            deptName = avalue;
        }
        public string DepartCode
        {
            get
            {
                return deptName;
            }
        }


        //WRITE ONLY PROPERTY
        private string faculty;
        public string FacultyName
        {
            set
            {
                faculty = value;
                Console.WriteLine("The Faculty is :{0}", faculty);
            }
        }

    }
}
