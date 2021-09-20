using System;
using System.Collections;

namespace ClassLib
{
    public class Student
    {
        int ID{get; set;}
        string GivenName{get; set;}
        string SurName{get; set;}
        Status Status
        {
            get
            {
                DateTime currentDate = DateTime.Now();
                if(EndDate < GraduationDate)
                {
                    //droput
                } 
                else if(EndDate == GraduationDate)
                {
                    //Graduated?
                } 
                else if(StartDate == currentDate)
                {
                    //new
                } else
                {
                    //active
                }
                
            }
        }
        DateTime StartDate{get; set;}
        DateTime EndDate{get; set;}
        DateTime GraduationDate{get; set;}
        public Student(int ID, string GivenName, string SurName, 
                DateTime StartDate, DateTime EndDate, DateTime GraduationDate)
        {
            this.ID = ID;
            this.GivenName = GivenName;
            this.SurName = SurName;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;
        }

        public override string ToString()
        {
            string toString = "ID: " + Student.id + " " + Student.GivenName + " " + 
            Student.SurName + " " + "insert status" + " " + Student.StartDate + " " + Student.EndDate 
            + " " + Student.GraduationDate;
            return toString;
        }
    }
}
