using System;
using System.Security.Cryptography.X509Certificates;

namespace Inside;

class Program{
    public static void Main(string[] args){
       Son son = new();
       Console.WriteLine(son.publicNumber);
       //Console.WriteLine(son.privateNumber);
       Console.WriteLine(son.PrivateNumber);

       Console.WriteLine(son.PrivateParentNumber);

       Console.WriteLine(son.InternalParentNumber);


    }
}