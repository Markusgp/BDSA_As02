using System;
using System.Collections;

namespace ClassLib
{
    public class Student
    {
        public int ID{get; set;}
        public string GivenName{get; set;}
        public string SurName{get; set;}
        public Status Status{get; init;}
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public DateTime GraduationDate{get; set;}
        public Student(int ID, string GivenName, string SurName, 
                DateTime StartDate, DateTime EndDate, DateTime GraduationDate)
        {
            this.ID = ID;
            this.GivenName = GivenName;
            this.SurName = SurName;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;
    
            DateTime currentDate = DateTime.Now;
            if(EndDate < GraduationDate)
            {
                Status = Status.DROPOUT;
            } 
            else if(EndDate == GraduationDate)
            {
                Status = Status.GRADUATED;
            } 
            else if(StartDate == currentDate)
            {
                Status = Status.NEW;
            } else
            {
                Status = Status.ACTIVE;
            }       
        }
        public override string ToString() => $"ID:{ID}, Name:{GivenName}, SurName:{SurName}, StartDate:{StartDate}, EndDate:{EndDate}, GraduationDate:{GraduationDate}";
    }
    public enum Status{
    NEW,
    ACTIVE,
    DROPOUT,
    GRADUATED
}
}
