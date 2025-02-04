using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticElements
{
    public static class TrainerDetails
    {
        // static field
        private static int s_trainerID;
        // static property
        public static string TrainerID{get;set;}
        public static string Name{get;set;}
    
        // static default constructor only
        static TrainerDetails(){
            TrainerID=$"SF{++s_trainerID}";
            Name="Arunesh";
        }
        // static methods
        public static string ShowData(){
            return $"ID: {TrainerID} \n Name: {Name}";
        }
        // static events
        
    }
}