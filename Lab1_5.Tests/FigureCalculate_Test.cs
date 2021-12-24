using NUnit.Framework;

namespace Lab1_5.Tests
{
    public class FigureCalculate_Test
    {
        
        [Test, Pairwise]
        public void GetTriangleExisting_False_Test(
            [Values(0, -1, 1)] int a,
            [Values(0, -1, -2)] int b,
            [Values(0, -1, -3)] int c)
        {
            bool actual = FigureCalculate.GetTriangleExists(a, b, c);

                Assert.IsFalse(actual);
        }

        [Test, Sequential]
        public void GetTriangle_True_Test(
            [Values(2, 3, 2)] int a,
            [Values(5, 10, 3)] int b,
            [Values(6, 11, 4)] int c
            )
        {
            bool actual = FigureCalculate.GetTriangleExists(a, b, c);

            Assert.IsTrue(actual);
        }

        [Test, Sequential]
        public void GetTriangle_False_Test(
            [Values(1, 2, 1)] int a,
            [Values(1, 5, 1)] int b,
            [Values(3, 11, 4)] int c
            )
        {
            bool actual = FigureCalculate.GetTriangleExists(a, b, c);

            Assert.IsFalse(actual);
        }

    }
}