namespace Shapes.Tests
{
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// �������� ������ ���������� ������� ����������
        /// </summary>
        [TestMethod]
        public void TestSquare()
        {
            var c = new Circle(5);
            double actual = c.GetSquare();
            double expected = 5 * 5 * Math.PI;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� ���������� ��� ������������� �������
        /// </summary>
        [TestMethod]
        public void TestCircleArgException1() {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var c = new Circle(-1);
            });
        }

        /// <summary>
        /// �������� ���������� ��� ������� �������
        /// </summary>
        [TestMethod]
        public void TestCircleArgException2() {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var c = new Circle(0);
            });
        }
    }
}