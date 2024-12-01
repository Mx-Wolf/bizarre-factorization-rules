using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Cli;

namespace FizzBuzz.CliTests
{
    public class RulesTests
    {
        private int baseValue = 0;
        [Fact]
        public void Rule3TrueOnTimes3()
        {
            baseValue = new Random().Next(33) * 3;
            var sut = GetSut();
            Assert.True(sut.Rule3());
        }

        [Fact]
        public void Rule3FalseOnTimes3Plus1()
        {
            baseValue = new Random().Next(33) * 3 + 1;
            var sut = GetSut();
            Assert.False(sut.Rule3());
        }
        [Fact]
        public void Rule5TrueOnTimes3()
        {
            baseValue = new Random().Next(20) * 5;
            var sut = GetSut();
            Assert.True(sut.Rule5());
        }

        [Fact]
        public void Rule5FalseOnTimes3Plus1()
        {
            baseValue = new Random().Next(20) * 5 + 1;
            var sut = GetSut();
            Assert.False(sut.Rule5());
        }

        private Rules GetSut()
        {
            return new Rules(baseValue);
        }
    }
}
