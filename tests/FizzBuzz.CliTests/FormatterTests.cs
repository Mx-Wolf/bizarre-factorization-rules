using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Cli;
using Microsoft.Extensions.Options;

namespace FizzBuzz.CliTests
{
    public class FormatterTests
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(16, "16")]
        public void KnownLabels(int i, string expected)
        {
            var sut = GetSut();
            var result = sut.Format(i);
            Assert.Equal(expected, result);
        }

        private Formatter GetSut()
        {
            return new Formatter(new OptionsWrapper<FormatterSettings>(new FormatterSettings()
            {
                Fizz = FormatterSettings.FizzInternal,
                Buzz = FormatterSettings.BuzzInternal,
            }), new Rules(new OptionsWrapper<RulesSettings>(RulesSettings.CreateDefault())));
        }
    }
}
