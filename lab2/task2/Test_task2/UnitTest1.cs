using Xunit;
using Menu;
using System;

    public class Test_task2
    {
        [Fact]
        public void isInside_20_14()
        {
            menu prog = new menu();
            int output = prog.isInside(20,14);
            Assert.True(output==1);
        }

        [Fact]
        public void isInside_50_14()
        {
            menu prog = new menu();
            int output = prog.isInside(50,14);
            Assert.True(output==2);
        }
        [Fact]
        public void isInside_50__14()
        {
            menu prog = new menu();
            int output = prog.isInside(50,-14);
            Assert.True(output==2);
        }
        [Fact]
        public void isInside_50_26()
        {
            menu prog = new menu();
            int output = prog.isInside(50,26);
            Assert.True(output==0);
        }
        [Fact]
        public void isInside_56__30()
        {
            menu prog = new menu();
            int output = prog.isInside(56, -30);
            Assert.True(output==0);
        }
    }