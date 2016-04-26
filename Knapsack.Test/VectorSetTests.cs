using System.Collections.Generic;
using Knapsack.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Knapsack.Test
{
    [TestClass]
    public class VectorSetTests
    {
/*
        [TestMethod]
        public void GivenEqualVectorSets_VectorSetEquals_ReturnsTrue()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 5),
                new Vector(3, 4)
            });
            VectorSet b = new VectorSet(new Vector[]
            {
                new Vector(3, 4),
                new Vector(1, 5)
            });

            // Act (��������)
            bool result = a.Equals(b);

            // Assert (��������)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void GivenVectorSet_ToString()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 5),
                new Vector(2, 3),
                new Vector(2, 7),
                new Vector(3, 4)
            });
            string expected = "{(1, 5), (2, 3), (2, 7), (3, 4)}";

            // Act (��������)
            string actual = a.ToString();

            // Assert (��������)
            Assert.AreEqual(expected, actual);
        }
*/
/*
        [TestMethod]
        public void GivenNonEqualVectorSets_VectorSetEquals_ReturnsFalse()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 5),
                new Vector(3, 10)
            });
            VectorSet b = new VectorSet(new Vector[]
            {
                new Vector(3, 4),
                new Vector(1, 5)
            });

            // Act (��������)
            bool result = a.Equals(b);

            // Assert (��������)
            Assert.IsFalse(result);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectorSets_VectorSetEqualityOperator_ReturnsTrue()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 5),
                new Vector(3, 4)
            });
            VectorSet b = new VectorSet(new Vector[]
            {
                new Vector(3, 4),
                new Vector(1, 5)
            });

            // Act (��������)
            bool result = a == b;

            // Assert (��������)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void GivenNonEqualVectorSets_VectorSetEqualityOperator_ReturnsFalse()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 5),
                new Vector(3, 4)
            });
            VectorSet b = new VectorSet(new Vector[]
            {
                new Vector(3, 4),
                new Vector(1, 7)
            });

            // Act (��������)
            bool result = a == b;

            // Assert (��������)
            Assert.IsFalse(result);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectorSets_VectorSetInequalityOperator_ReturnsFalse()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 5),
                new Vector(3, 4)
            });
            VectorSet b = new VectorSet(new Vector[]
            {
                new Vector(3, 4),
                new Vector(1, 5)
            });

            // Act (��������)
            bool result = a != b;

            // Assert (��������)
            Assert.IsFalse(result);
        }
*/
/*
        [TestMethod]
        public void GivenNonEqualVectorSets_VectorSetInequalityOperator_ReturnsTrue()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 6),
                new Vector(3, 4)
            });
            VectorSet b = new VectorSet(new Vector[]
            {
                new Vector(3, 4),
                new Vector(1, 5)
            });

            // Act (��������)
            bool result = a != b;

            // Assert (��������)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void GivenSameVectors_VectorSetHasNoDuplicates()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 6),
                new Vector(3, 4),
                new Vector(1, 6),
                new Vector(5, 7),
                new Vector(3, 4)
            });
            VectorSet b = new VectorSet(new Vector[]
            {
                new Vector(5, 7),
                new Vector(1, 6),
                new Vector(3, 4)
            });

            // Act (��������)
            bool result = a == b;

            // Assert (��������)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void GivenVectorSet_Enumerate()
        {
            // Arrange (����������)
            var sourceVectors = new Vector[]
            {
                new Vector(1, 6),
                new Vector(3, 4),
                new Vector(1, 6),
                new Vector(5, 7),
                new Vector(3, 4)
            };
            VectorSet a = new VectorSet(sourceVectors);
            List<Vector> collectedVectors = new List<Vector>();

            // Act (��������)
            foreach (Vector vector in a)
            {
                collectedVectors.Add(vector);
            }

            // Assert (��������)
            Assert.AreEqual(3, collectedVectors.Count);
            foreach (var sourceVector in sourceVectors)
            {
                Assert.IsTrue(collectedVectors.Contains(sourceVector));
            }
        }
*/
/*
        [TestMethod]
        public void GivenVectorSet_FindEffective()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 6),
                new Vector(5, 9),
                new Vector(6, 8),
                new Vector(3, 4),
            });
            VectorSet expected = new VectorSet(new Vector[]
            {
                new Vector(5, 9),
                new Vector(6, 8)
            });

            // Act (��������)
            VectorSet actual = a.FindEffective();

            // Assert (��������)
            Assert.AreEqual(expected, actual);
        }
*/
/*
        [TestMethod]
        public void Given2VectorSets_With()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 6),
                new Vector(5, 9),
                new Vector(6, 8),
                new Vector(3, 4),
                new Vector(7, 7)
            });
            VectorSet b = new VectorSet(new Vector[]
            {
                new Vector(5, 9),
                new Vector(2, 1),
                new Vector(3, 4),
                new Vector(5, 5)
            });
            VectorSet expected = new VectorSet(new Vector[]
            {
                new Vector(1, 6),
                new Vector(5, 9),
                new Vector(6, 8),
                new Vector(3, 4),
                new Vector(7, 7),
                new Vector(2, 1),
                new Vector(5, 5)
            });

            // Act (��������)
            VectorSet actual = a.With(b);

            // Assert (��������)
            Assert.AreEqual(expected, actual);
        }
*/
/*
        [TestMethod]
        public void GivenVectorSet_Contains()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 6),
                new Vector(5, 9),
                new Vector(6, 8),
                new Vector(3, 4),
                new Vector(7, 7)
            });

            // Act (��������) + Assert (��������)
            Assert.IsTrue(a.Has(new Vector(5, 9)));
            Assert.IsTrue(a.Has(new Vector(6, 8)));
            Assert.IsFalse(a.Has(new Vector(3, 8)));
        }
*/
/*
        [TestMethod]
        public void GivenVectorSetAndVector_VectorSetSumOperator_AddsVectorToAllElements()
        {
            // Arrange (����������)
            VectorSet a = new VectorSet(new Vector[]
            {
                new Vector(1, 6),
                new Vector(5, 9),
                new Vector(6, 8),
                new Vector(3, 4),
            });
            Vector b = new Vector(3, 4);
            VectorSet expected = new VectorSet(new Vector[]
            {
                new Vector(4, 10),
                new Vector(8, 13),
                new Vector(9, 12),
                new Vector(6, 8),
            });

            // Act (��������)
            VectorSet actual1 = a + b;
            VectorSet actual2 = b + a;

            // Assert (��������)
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }
 */
    }
}