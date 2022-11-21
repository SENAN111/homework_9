using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsilation.Models

{
    internal class Student
    {
        private string Name;
        private string Surname;
        private double AvgPoint;
        public void SetAvgPOint(double value)
        {
            if (value >= 0 && value <= 100)
            {
                AvgPoint= value;
            }
        }
        public double GetAvgPOint()
        {
            return AvgPoint;
        }
        public void SetSurname(string value)
        {
            Surname= value.Trim();
        }
        public string GetSurname()
        {
            return Surname;
        }
        public void SetName(string value) 
        {  
            Name= value.Trim();
        }
        public string GetName() 
        {
            return Name;
        }
        
    }
            
                

                
}
