using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using collegeAdmissionLibrary;
namespace Application;
class Program
{
    public static void Main(string[] args)
    {
        // Get student1's details
        // Create folder for putting copies of student form
        List<StudentDetails> students = new List<StudentDetails>();
        string option = "";
        do
        {
            // action to be repeated
            // StudentDetails student1 = new StudentDetails();
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Father name:");
            string fatherName = Console.ReadLine();
            // Console.WriteLine("Enter gender 1.male 2.female 3.transgender :");
            // GenderDetails gender1 =(GenderDetails) int.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender:");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(),true);
            Console.WriteLine("Enter date of birth:");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("Enter physics mark:");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter chemistry mark:");
            int chemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maths mark:");
            int maths = int.Parse(Console.ReadLine());
            StudentDetails student1 = new StudentDetails(name, fatherName, gender, dob, physics, chemistry, maths);
            students.Add(student1);
            Console.WriteLine($"Your registration successfull. Registration ID {student1.StudentID}");
            // termination
            Console.WriteLine("Do you want another student?");
            option = Console.ReadLine();
        } while (option.ToLower() == "yes"); //action to be repeated

        Console.WriteLine("Enter your ID");
        string studentID = Console.ReadLine().ToUpper();

        // List the details
        foreach (StudentDetails student in students)
        {
            if(studentID.Equals(student.StudentID)){
            Console.WriteLine($" student detail: \n ID:{student.StudentID} \n Name:{student.Name} \n Father name:{student.FatherName} \n Gender:{student.Gender} \n Date of birth:{student.DOB} \n Physics mark:{student.Physics} \n Chemistry mark:{student.Chemistry} \n Maths mark:{student.Maths}");
            if (student.IsEligible(75))
            {
                Console.WriteLine("You are eligible for admission");
            }
            else{
                Console.WriteLine("You are not eligible for admission");
            }
            }
        }
    }
}
