using System;
using enumStatus;
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
            set
            {
                var currentDate = DateTime.Now;
                if(EndDate < GraduationDate)
                {
                    Status = Status.DROPOUT;
                    return;
                    //droput
                } 
                else if(EndDate == GraduationDate)
                {
                    Status = Status.GRADUATED;
                    return;
                    //Graduated?
                } 
                else if(StartDate == currentDate)
                {
                    Status = Status.NEW;
                    return;
                    //new
                } else
                {
                    Status = Status.ACTIVE;
                    return;
                    //active
                }
                
            }get{return Status;}
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

        public override string ToString() => $"ID:{ID}, GivenName:{GivenName}, SurName:{SurName}, StartDate:{StartDate.ToString()}, EndDate:{EndDate.ToString()}, GraduationDate:{GraduationDate.ToString()}";
    }

}
