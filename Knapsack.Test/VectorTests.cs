using Knapsack.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Knapsack.Test
{
    [TestClass]
    public class VectorTests
    {
/*
        [TestMethod]
        public void GivenVector_ToString()
        {
            // Arrange (����������)
            Vector a = new Vector(1, 5);
            string expected = "(1, 5)";

            // Act (��������)
            string actual = a.ToString();

            // Assert (��������)
            Assert.AreEqual(expected, actual);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectors_VectorEquals_ReturnsTrue()
        {
            // Arrange (����������)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(1, 5);

            // Act (��������)
            bool result = a.Equals(b);

            // Assert (��������)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void GivenNonEqualVectors_VectorEquals_ReturnsFalse()
        {
            // Arrange (����������)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(3, 5);
            
            // Act (��������)
            bool result = a.Equals(b);

            // Assert (��������)
            Assert.IsFalse(result);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectors_VectorEqualityOperator_ReturnsTrue()
        {
            // Arrange (����������)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(1, 5);

            // Act (��������)
            bool result = a == b;

            // Assert (��������)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void GivenNonEqualVectors_VectorEqualityOperator_ReturnsFalse()
        {
            // Arrange (����������)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(3, 5);

            // Act (��������)
            bool result = a == b;

            // Assert (��������)
            Assert.IsFalse(result);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectors_VectorInequalityOperator_ReturnsFalse()
        {
            // Arrange (����������)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(1, 5);

            // Act (��������)
            bool result = a != b;

            // Assert (��������)
            Assert.IsFalse(result);
        }
*/
/*
        [TestMethod]
        public void GivenNonEqualVectors_VectorInequalityOperator_ReturnsTrue()
        {
            // Arrange (����������)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(3, 5);

            // Act (��������)
            bool result = a != b;

            // Assert (��������)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void Given2Vectors_VectorAddOperator_AddsVectors()
        {
            // Arrange (����������)
            Vector a = new Vector(1, 64);
            Vector b = new Vector(3, 5);

            // Act (��������)
            Vector result = a + b;

            // Assert (��������)
            Assert.AreEqual(new Vector(4, 69), result);
        }
*/
/*
        [TestMethod]
        public void Given2Vectors_VectorMinusOperator_SubstractsVectors()
        {
            // Arrange (����������)
            Vector a = new Vector(1, 64);
            Vector b = new Vector(3, 5);

            // Act (��������)
            Vector result = a - b;

            // Assert (��������)
            Assert.AreEqual(new Vector(-2, 59), result);
        }
*/
/*
        [TestMethod]
        public void GivenVectorCanBeComparedVaryByBothComponents_VectorCompare_ReturnsBetterAndWorse()
        {
            // Arrange (����������)
            Vector a = new Vector(6, 7);
            Vector b = new Vector(3, 5);

            // Act (��������)
            ComparisonResult result1 = a.Compare(b);
            ComparisonResult result2 = b.Compare(a);

            // Assert (��������)
            Assert.AreEqual(ComparisonResult.Better, result1);
            Assert.AreEqual(ComparisonResult.Worse, result2);
        }
*/
/*
        [TestMethod]
        public void GivenVectorCanBeComparedVaryBy1stComponent_VectorCompare_ReturnsBetterAndWorse()
        {
            // Arrange (����������)
            Vector a = new Vector(6, 7);
            Vector b = new Vector(3, 7);

            // Act (��������)
            ComparisonResult result1 = a.Compare(b);
            ComparisonResult result2 = b.Compare(a);

            // Assert (��������)
            Assert.AreEqual(ComparisonResult.Better, result1);
            Assert.AreEqual(ComparisonResult.Worse, result2);
        }
*/
/*
        [TestMethod]
        public void GivenVectorCanBeComparedVaryBy2ndComponent_VectorCompare_ReturnsBetterAndWorse()
        {
            // Arrange (����������)
            Vector a = new Vector(6, 7);
            Vector b = new Vector(6, 5);

            // Act (��������)
            ComparisonResult result1 = a.Compare(b);
            ComparisonResult result2 = b.Compare(a);

            // Assert (��������)
            Assert.AreEqual(ComparisonResult.Better, result1);
            Assert.AreEqual(ComparisonResult.Worse, result2);
        }
*/
/*
        [TestMethod]
        public void GivenVectorCanNotBeCompared_VectorCompare_ReturnsNotComparable()
        {
            // Arrange (����������)
            Vector a = new Vector(6, 4);
            Vector b = new Vector(3, 5);

            // Act (��������)
            ComparisonResult result1 = a.Compare(b);
            ComparisonResult result2 = b.Compare(a);

            // Assert (��������)
            Assert.AreEqual(ComparisonResult.NotComparable, result1);
            Assert.AreEqual(ComparisonResult.NotComparable, result2);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectors_VectorCompare_ReturnsNotComparable()
        {
            // Arrange (����������)
            Vector a = new Vector(6, 4);
            Vector b = new Vector(6, 4);

            // Act (��������)
            ComparisonResult result = a.Compare(b);

            // Assert (��������)
            Assert.AreEqual(ComparisonResult.NotComparable, result);
        }
*/
    }
}