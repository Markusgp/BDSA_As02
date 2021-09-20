using System;
using System.Collections;

namespace ClassLib
{
    }
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
                    Status = Status.DROPOUT
                    //droput
                } 
                else if(EndDate == GraduationDate)
                {
                    Status = Status.Graduated
                    //Graduated?
                } 
                else if(StartDate == currentDate)
                {
                    Status = Status.NEW
                    //new
                } else
                {
                    Status = Status.ACTIVE
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

        public override string ToString() => $"ID:{ID}, Name:{GivenName}, SurName:{SurName}, StartDate:{StartDate}, EndDate:{EndDate}, GraduationDate:{GraduationDate}";
    }


    public record ImmutableStudent {
        int ID{get; init;}
        string GivenName{get; init;}
        string SurName{get; init;}
        Status Status
        {
            get
            {
                DateTime currentDate = DateTime.Now();
                if(EndDate < GraduationDate)
                {
                    Status = Status.DROPOUT
                    //droput
                } 
                else if(EndDate == GraduationDate)
                {
                    Status = Status.Graduated
                    //Graduated?
                } 
                else if(StartDate == currentDate)
                {
                    Status = Status.NEW
                    //new
                } else
                {
                    Status = Status.ACTIVE
                    //active
                }
                
            }
        }
        DateTime StartDate{get; init;}
        DateTime EndDate{get; init;}
        DateTime GraduationDate{get; init;}
        public ImmutableStudent(int ID, string GivenName, string SurName, 
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
