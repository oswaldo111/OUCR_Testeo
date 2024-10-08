using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OUCR.Strings;
namespace OUCR.Temperatura.UnitTestxUnit
{
    public class StringsTest
    {
        [Fact]
        public void ReverseStrinstestxUnit()
        {
            StringManipulator stringManipulator = new StringManipulator();

            Assert.Equal("qwe", stringManipulator.ReverseString("ewq"));
        }

        [Fact]
        public void RemoveStrinsxUnit()
        {
            StringManipulator strManipulator = new StringManipulator();

            Assert.Equal("casade", strManipulator.RemoveString("casa de"));
        }
    }
}
