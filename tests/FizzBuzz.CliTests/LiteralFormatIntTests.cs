using FizzBuzz.Cli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;

namespace FizzBuzz.CliTests
{
    public class LiteralFormatIntTests
    {
        private string literal = string.Empty;
        private readonly Fixture fix = new Fixture();
        [Fact]
        public void ProvidesTheSameString()
        {
            literal = fix.Create<string>();
            var x = fix.Create<int>();
            var sut = GetSut();
            var result = sut.Format(x);
            Assert.Equal(literal, result);
        }

        private LiteralFormatInt GetSut()
        {
            return new LiteralFormatInt(literal);
        }
    }
}
