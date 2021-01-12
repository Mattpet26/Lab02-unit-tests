using System;
using Xunit;
using Lab02_unit_tests;

namespace Lab02_Test
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalanceWorking()
        {
            int balance = 1000;

            decimal result = Program.ViewBalance();

            Assert.Equal(balance, result);
        }
    }
}




