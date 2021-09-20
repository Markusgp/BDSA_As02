using System;
using Xunit;
using System.IO;

namespace ClassLib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ToString_OutPut_Student()
        {
            //arrange
            DateTime StartDate = new DateTime(2017, 06, 10);
            DateTime EndDate = new DateTime(2020, 06, 25);
            DateTime GraduationDate = new DateTime(2020, 06, 25);

            Student student = new Student(10, "navn", "efternavn", StartDate, EndDate, GraduationDate);
           

            //act
            string actual = student.toString();
            string expected = "ID:10, GivenName:navn, SurName:efternavn, StartDate:06/10/2017, EndDate:06/25/2020, GraduationDate:06/25/2020";

            //"ID:{ID}, Name:{GivenName}, SurName:{SurName}, StartDate:{StartDate}, EndDate:{EndDate}, GraduationDate:{GraduationDate}"
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
