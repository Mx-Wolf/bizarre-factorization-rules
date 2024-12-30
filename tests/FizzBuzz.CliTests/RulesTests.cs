using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Cli;
using Microsoft.Extensions.Options;

namespace FizzBuzz.CliTests
{
    public class RulesTests
    {
        [Theory]
        [InlineData(3, false)]
        [InlineData(5, true)]
        [InlineData(7, false)]
        public void KnownLargerDivisibility(int i, bool expected)
        {
            var sut = GetSut();
            var result = sut.MultipleToLargeDivisor(i);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(3, true)]
        [InlineData(5, false)]
        [InlineData(7, false)]
        public void KnownSmallerDivisibility(int i, bool expected)
        {
            var sut = GetSut();
            var result = sut.MultipleToSmallDivisor(i);
            Assert.Equal(expected, result);
        }

        private Rules GetSut()
        {
            return new Rules(new OptionsWrapper<RulesSettings>(RulesSettings.CreateDefault()));
        }
    }
}
