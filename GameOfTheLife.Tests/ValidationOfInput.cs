using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfTheLife.Logic;
namespace GameOfTheLife.Tests
{
    /// <summary>
    /// Summary description for ValidationOfInput
    /// </summary>
    [TestClass]
    public class ValidationOfInput
    {
        public ValidationOfInput()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {

            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void User_Input_Validation()
        {
            //   GameGrid gr = new GameGrid(12,15);
            //if


            //}
            //
            // TODO: Add test logic here
            //


        }
        [TestMethod]
        public void UserInputTest()
        {
            int xW = 5;
            int yH = 4;


            GameGrid gr = new GameGrid(12, 4);

        }
    }
}
