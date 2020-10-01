using System;
using Xunit;

namespace Exercise.Tests
{
    public class UnitTest1
    {
        private Exercise.Program prog;
        public UnitTest1()
        {
            prog = new Program();
        }
        [Fact]
        public void Test1()
        {
            Assert.True(prog.CalSum(2,3) == 4);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(prog.CalSum(2, 3) == 5);
        }
        [Fact]
        public void Test3()
        {
            Assert.True(prog.CalSum(3, 3) == 4);
        }
    }
}
