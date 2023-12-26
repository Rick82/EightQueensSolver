namespace TestEightQueensSolver
{
    using EightQueens;

    [TestClass]
    public class UnitTestSolCount
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t1 = new EightQueensSolver(1);
            t1.PutQueen(0);
            Assert.AreEqual(1, t1.SolutionCount);

            var t2 = new EightQueensSolver(2);
            t2.PutQueen(0);
            Assert.AreEqual(0, t2.SolutionCount);

            var t3 = new EightQueensSolver(3);
            t3.PutQueen(0);
            Assert.AreEqual(0, t3.SolutionCount);

            var t4 = new EightQueensSolver(4);
            t4.PutQueen(0);
            Assert.AreEqual(2, t4.SolutionCount);

            var t5 = new EightQueensSolver(5);
            t5.PutQueen(0);
            Assert.AreEqual(10, t5.SolutionCount);

            var t6 = new EightQueensSolver(6);
            t6.PutQueen(0);
            Assert.AreEqual(4, t6.SolutionCount);
            var t7 = new EightQueensSolver(7);
            t7.PutQueen(0);
            Assert.AreEqual(40, t7.SolutionCount);

            var t8 = new EightQueensSolver(8);
            t8.PutQueen(0);
            Assert.AreEqual(92, t8.SolutionCount);

            var t9 = new EightQueensSolver(9);
            t9.PutQueen(0);
            Assert.AreEqual(352, t9.SolutionCount);

            var t10 = new EightQueensSolver(10);
            t10.PutQueen(0);
            Assert.AreEqual(724, t10.SolutionCount);
        }
    }
}