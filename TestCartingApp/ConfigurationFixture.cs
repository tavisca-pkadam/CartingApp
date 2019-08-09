using System;
using System.Linq;
using Xunit;
using FluentAssertions;
using CartingApp;

namespace TestCartingApp
{
    public class ConfigurationFixture
    {
        [Fact]
        public void TestGetConfiguation()
        {
            var variableDiscount = Configuration.GetConfigurationDiscount();
            variableDiscount.Should().Be(10);
        }
    }
}
