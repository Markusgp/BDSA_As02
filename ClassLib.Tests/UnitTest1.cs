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
            Student student = new Student();
            student.id = 10;
            string output = student.ToString();
            string expected = "10";
            Assert.Equal(expected, output);
        }
    }
}
