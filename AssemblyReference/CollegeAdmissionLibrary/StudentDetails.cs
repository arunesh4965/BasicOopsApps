using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace collegeAdmissionLibrary
{
    public class StudentDetails : IDisposable
    {
        // propertise
        // name, fatherName, gender, dob, physics, chemistry, maths
        /*private string _firstName; //field
        public string FirstName //property -r/w
        {
            get{return _firstName;}
            set{_firstName=value;}
        }*/
        private static int s_studentId=4000; // increment purpose
        public string StudentID { get; set; } // to store id in form of SF4001
        public string Name { get; set; }   //auto implemented property-accessors -read only
        public string FatherName { get; set; }
        public GenderDetails Gender { get; set; }
        public DateTime DOB { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        // Contructors - behaviour/methods - used to assign value to its attributes
        // default Constructor
        public StudentDetails()
        {
            StudentID = $"SF{++s_studentId}";
            Name = "";
            FatherName = "";
            DOB = DateTime.Now;
            Gender = GenderDetails.Unknown;
        }
        // Parametrised Constructor
        public StudentDetails(string name, string fatherName, GenderDetails gender, DateTime dob, int physics, int chemistry, int maths)
        {
            StudentID = $"SF{++s_studentId}";
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public StudentDetails(string name, string fatherName, GenderDetails gender, DateTime dob)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
        }
        ~StudentDetails()
        {

        }

        public int Total()
        {
            return Physics + Chemistry + Maths;
        }

        public double Average()
        {
            return (double)Total() / 3;
        }

        public bool IsEligible(double cutoff)
        {
            if (Average() >= cutoff)
            {
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            Name = null;
            GC.SuppressFinalize(this);
            GC.Collect();
        }
    }
}