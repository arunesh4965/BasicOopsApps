using System;
namespace StaticElements;
class Program{
    public static void Main(string[] args){
        StudentDetails student = new StudentDetails()
        {
            Name = "Arunesh"
        };
        StudentDetails student1 = new()
        {
            Name = "Bala"
        };
        StudentDetails student2 = new()
        {
            Name = "Subramanian"
        };

        Console.WriteLine(TrainerDetails.ShowData());
        TrainerDetails.Name="Arun";
        TrainerDetails.TrainerID="SF1001";
    }
}