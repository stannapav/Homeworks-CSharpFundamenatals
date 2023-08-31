using Homework10;

namespace Homework10Test
{
    [TestClass]
    public class Triangle_test
    {
        [TestMethod]
        public void CompareDistanceMethodPointAndTriangle()
        {
            Point a = new Point(0, 1);
            Point b = new Point(1, 1);
            Point c = new Point(1, 0);
            Triangle triangle = new Triangle(a, b, c);

            double pointDistanceA = a.Distance(b);
            double triangleDistanceA = triangle.Distance(a, b);
            double pointDistanceB = b.Distance(c);
            double triangleDistanceB = triangle.Distance(b, c);
            double pointDistanceC = c.Distance(a);
            double triangleDistanceC = triangle.Distance(c, a);


            Assert.AreEqual(pointDistanceA, triangleDistanceA);
            Assert.AreEqual(pointDistanceB, triangleDistanceB);
            Assert.AreEqual(pointDistanceC, triangleDistanceC);
        }

        [TestMethod]
        public void TrianglePerimetr()
        {
            Point a = new Point(0, 1);
            Point b = new Point(1, 1);
            Point c = new Point(1, 0);
            Triangle triangle = new Triangle(a, b, c);

            double expected = 2 + Math.Sqrt(2);

            Assert.AreEqual(expected, triangle.Perimeter());
        }

        [TestMethod]
        public void TriangleSquare()
        {
            Point a = new Point(0, 1);
            Point b = new Point(1, 1);
            Point c = new Point(1, 0);
            Triangle triangle = new Triangle(a, b, c);

            double expected = 0.5;

            Assert.AreEqual(expected, Math.Round(triangle.Square(), 2));
        }
    }
}