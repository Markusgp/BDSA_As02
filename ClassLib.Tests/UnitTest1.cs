using System;
using Xunit;
using immutable;
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
            string actual = student.ToString();
            string expected = "ID:10, GivenName:navn, SurName:efternavn, StartDate:06/10/2017 00/00/00, EndDate:06/25/2020 00/00/00, GraduationDate:06/25/2020 00/00/00";

            //"ID:{ID}, Name:{GivenName}, SurName:{SurName}, StartDate:{StartDate}, EndDate:{EndDate}, GraduationDate:{GraduationDate}"
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void compare_2_same_record_objects_isTrue(){
            DateTime StartDate = new DateTime(2017, 06, 10);
            DateTime EndDate = new DateTime(2020, 06, 25);
            DateTime GraduationDate = new DateTime(2020, 06, 25);
                var obj1 = new ImmutableStudent(1, "Deniz", "Isik", StartDate, EndDate, GraduationDate);
                var obj2 = new ImmutableStudent(1, "Deniz", "Isik", StartDate, EndDate, GraduationDate);

                Assert.Equal(obj1, obj2);
               
        }
    }
}
