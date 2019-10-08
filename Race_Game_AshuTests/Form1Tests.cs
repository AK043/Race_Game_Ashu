using Microsoft.VisualStudio.TestTools.UnitTesting;
using Race_Game_Ashu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Game_Ashu.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            // calling the constructor of the details class with passing the values 
            details obj = new details("check",1,1,1);

        }

        [TestMethod()]
        public void mainTest()
        {
            // testing the main class to check the working of the whole game 
            Form1 obj = new Form1();

        }


    }
}