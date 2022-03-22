using Xunit;
using Prime.Services;
using Menu;
using System;

namespace Prime.UnitTests.Services;

    public class PrimeService_IsEvenSum
    {
        [Fact]
        public void isSumCEven_13()
        {
            menu prog = new menu();
            int a=13;
            bool test = prog.isSumEven(a) && prog.isNumOk(a);

            Assert.True(test);
        }

        [Fact]
        public void isSumCEven_138()
        {
            menu prog = new menu();
            int a=138;
            bool test = prog.isSumEven(a) && prog.isNumOk(a);

            Assert.False(test);
        }
        [Fact]
        public void isSumCEven_15()
        {
            menu prog = new menu();
            int a=16;
            bool test = prog.isSumEven(a) && prog.isNumOk(a);

            Console.WriteLine(test);

            Assert.False(test);
        }
    }