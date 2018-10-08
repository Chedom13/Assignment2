using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QA_Assignment2;

namespace QA_Assignment2_Test
{
    [TestFixture]
    public class QA_Assignment2_Test
    {
        [TestCase]
        public void GetTriangleType_input1_2_3_expectScalene()
        {
            //Arrange
            int input1 = 1;
            int input2 = 2;
            int input3 = 3;

            //Act
            string result = TriangleSolver.Analyze(input1, input2, input3);

            //Assert
            Assert.AreEqual(result, "Scalene");
        }

        [TestCase]
        public void GetTriangleType_input1_1_3_expectIsosceles()
        {
            //Arrange
            int input1 = 1;
            int input2 = 1;
            int input3 = 3;

            //Act
            string result = TriangleSolver.Analyze(input1, input2, input3);

            //Assert
            Assert.AreEqual(result, "Isosceles");
        }

        [TestCase]
        public void GetTriangleType_input1_2_1_expectIsosceles()
        {
            //Arrange
            int input1 = 1;
            int input2 = 2;
            int input3 = 1;

            //Act
            string result = TriangleSolver.Analyze(input1, input2, input3);

            //Assert
            Assert.AreEqual(result, "Isosceles");
        }

        [TestCase]

        public void GetTriangleType_input1_2_2_expectIsosceles()
        {
            //Arrange
            int input1 = 1;
            int input2 = 2;
            int input3 = 2;

            //Act
            string result = TriangleSolver.Analyze(input1, input2, input3);

            //Assert
            Assert.AreEqual(result, "Isosceles");
        }

        [TestCase]
        public void GetTriangleType_input2_2_2_expectIsosceles()
        {
            //Arrange
            int input1 = 2;
            int input2 = 2;
            int input3 = 2;

            //Act
            string result = TriangleSolver.Analyze(input1, input2, input3);

            //Assert
            Assert.AreEqual(result, "Equilateral");
        }

        [TestCase]

        public void GetTriangleType_input0_2_2_expectCantForm()
        {
            //Arrange
            int input1 = 0;
            int input2 = 2;
            int input3 = 2;

            //Act
            string result = TriangleSolver.Analyze(input1, input2, input3);

            //Assert
            Assert.AreEqual(result, "Cannot form a triangle");
        }

        [TestCase]
        public void GetTriangleType_inputMinus3_2_2_expectCantForm()
        {
            //Arrange
            int input1 = -3;
            int input2 = 2;
            int input3 = 2;

            //Act
            string result = TriangleSolver.Analyze(input1, input2, input3);

            //Assert
            Assert.AreEqual(result, "Cannot form a triangle");
        }

        [TestCase]
        public void GetTriangleType_input0_0_0_expectCantForm()
        {
            //Arrange
            int input1 = 0;
            int input2 = 0;
            int input3 = 0;

            //Act
            string result = TriangleSolver.Analyze(input1, input2, input3);

            //Assert
            Assert.AreEqual(result, "Cannot form a triangle");
        }

        [TestCase]
        public void GetTriangleType_inputMinus2_Minus2_Minus2_expectCantForm()
        {
            //Arrange
            int input1 = -2;
            int input2 = -2;
            int input3 = -2;

            //Act
            string result = TriangleSolver.Analyze(input1, input2, input3);

            //Assert
            Assert.AreEqual(result, "Cannot form a triangle");
        }
    }
}