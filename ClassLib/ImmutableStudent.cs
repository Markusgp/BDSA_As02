using System;
using enumStatus;
namespace immutable {



public record ImmutableStudent {
        int ID{get; init;}
        string GivenName{get; init;}
        string SurName{get; init;}
        Status Status
        {
            set
            {
                var currentDate = DateTime.Now;
                if(EndDate < GraduationDate)
                {
                    Status = Status.DROPOUT;
                    //droput
                    return;
                    
                } 
                else if(EndDate == GraduationDate)
                {
                    Status = Status.GRADUATED;
                    //Graduated?
                    return;
                } 
                else if(StartDate == currentDate)
                {
                    Status = Status.NEW;
                    //new
                    return;
                } else
                {
                    Status = Status.ACTIVE;
                    //active
                    return;
                }
                
            }get{return Status;}
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

            public override string ToString() => $"ID:{ID}, Name:{GivenName}, SurName:{SurName}, StartDate:{StartDate.ToString()}, EndDate:{EndDate.ToString()}, GraduationDate:{GraduationDate.ToString()}";

    }
}