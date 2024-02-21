using NuGet.Frameworks;

namespace ShapeTests
{
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// �������� ������ ���������� ������� ������������
        /// </summary>
        [TestMethod]
        public void TestSquare()
        {
            var t = new Triangle(3, 4, 5);
            var actual = t.GetSquare();
            var expected = 6;
            Assert.AreEqual(expected, actual); 
        }

        /// <summary>
        /// �������� ���������� �� �������������� �����������
        /// </summary>
        [TestMethod]
        public void TestTriangleArgException() {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var t = new Triangle(6, -5, 6); 
            });
        }

        /// <summary>
        /// �������� �� ������������� �����������
        /// </summary>
        [TestMethod]
        public void TestRectangleTriangle()
        {
            var t = new Triangle(3, 4, 5);
            var actual = t.IsRectangular;
            var expected = true;
            Assert.AreEqual(expected, actual);  
        }

        /// <summary>
        /// �������� �� ��������������� �����������
        /// </summary>
        [TestMethod]
        public void TestNotRectangleTriangle()
        {
            var t = new Triangle(3, 5, 5);
            var actual = t.IsRectangular;
            var expected = false;  
            Assert.AreEqual(expected, actual);
        }
        
    }
}