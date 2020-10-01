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
            Assert.True(prog.SayHello().Equals("Hello World!"), "Your program is not welcoming!");
        }

        [Fact]
        public void Test2()
        {
            Assert.True(prog.SayGoodBye().Equals("GoodBye World!"),"Your program does not say GoodBye correctly!");
        }
    }
}
