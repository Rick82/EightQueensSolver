namespace EightQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            var eightQueensSolver = new EightQueensSolver();
            eightQueensSolver.PutQueen(0);
            Console.ReadKey();
        }
    }
}