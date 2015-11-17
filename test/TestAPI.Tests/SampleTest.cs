using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using TestAPI.Models;

namespace TestAPI.Tests
{
    public class SampleTest
    {
        [Fact]
        public void Test1()
        {
            var debate = new Debate();
            Assert.True(true);
        }
    }
}
