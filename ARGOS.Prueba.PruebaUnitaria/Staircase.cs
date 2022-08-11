

namespace ARGOS.Prueba.PruebaUnitaria
{
    using ARGOS.Prueba.Algoritmos;
    using NUnit.Framework;

    /// <summary>
    /// Class test
    /// </summary>
    public class Staircase
    {
        [Test]
        public void CreateMatrixTest()
        {
            string[,] matrixToEval = new string[3, 3] { { null, null, "#" }, { null, "#", "#" }, { "#", "#", "#" } };

            string[,] matrix = Program.Staircase(3);
            Assert.AreEqual(matrix, matrixToEval);
        }
    }
}