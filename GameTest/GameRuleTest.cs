using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameController;
namespace GameTest
{
    [TestClass]
    public class GameRuleTest
    {
             /// <summary>
             /// Any live cell with 0 neighbors dies.
             /// </summary>
        [TestMethod]
        public void Any_Live_Cell_With_Neighbours_0()
        {

            CellStatus currentState = CellStatus.Alive;
            int liveNeighbors = 0;

            CellStatus result = GameRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellStatus.Dead, result);
        }

        /// <summary>
        /// Any live cell with 1 live neighbors dies.
        /// </summary>
        [TestMethod]
        public void Any_Live_Cell_With_Neighbours_1()
        {
            CellStatus currentStat = CellStatus.Alive;
            int liveNeigbors = 1;

            CellStatus result = GameRules.GetNewState(currentStat, liveNeigbors);

            Assert.AreEqual(CellStatus.Dead, result);
        }

        /// <summary>
        /// Any live cell with  two live neighbors alive.
        /// </summary>
        [TestMethod]
        public void AnyLiveCellWithTwoNeighbors_2()
        {
            CellStatus currentstate = CellStatus.Alive;
            int liveNeighbors = 2;

            CellStatus result = GameRules.GetNewState(currentstate, liveNeighbors);

            Assert.AreEqual(CellStatus.Alive, result);
        }

        /// <summary>
        /// Any live cell with  three live neighbors alive.
        /// </summary>
        [TestMethod]
        public void AnyLiveCellWithThreeNeighbors_3()
        {
            CellStatus curentstate = CellStatus.Alive;

            int liveNeighbors = 3;

            CellStatus result = GameRules.GetNewState(curentstate, liveNeighbors);

            Assert.AreEqual(CellStatus.Alive, result);
        }
        /// <summary>
        /// Any live cell with  4 live neighbors die.
        /// </summary>
        [TestMethod]
        public void AnyLiveCellWithFourNeigbors_4()
        {
            CellStatus currentState = CellStatus.Alive;
            int liveNeighbors = 4;

            CellStatus result = GameRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellStatus.Dead, result);

        }

        /// <summary>
        /// Any live cell with  5 live neighbors dies.
        /// </summary>
        [TestMethod]
        public void AnyCellWithWithFiveNeighbors_5()
        {
            CellStatus currentState = CellStatus.Alive;
            int liveCells = 5;

            CellStatus resultForNextIteration = GameRules.GetNewState(currentState, liveCells);

            Assert.AreEqual(CellStatus.Dead, resultForNextIteration);
        }
        /// <summary>
        /// Any live cell with  six live neighbors dies.
        /// </summary>
        [TestMethod]
        public void AnyLiveCellWithSixNeigbors_6()
        {
            CellStatus currentState = CellStatus.Alive;
            int liveNeighbors = 6;

            CellStatus nextIteration = GameRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellStatus.Dead, nextIteration);


        }
        /// <summary>
        /// Any dead cell with no neighbors dies.
        /// </summary>
        [TestMethod]
        public void DeadCellNoLiveNeighbors_0()
        {
            CellStatus current = CellStatus.Dead;
            int liveNeighbors = 0;

            CellStatus nextGeneration = GameRules.GetNewState(current, liveNeighbors);


            Assert.AreEqual(CellStatus.Dead, nextGeneration);

        }

        /// <summary>
        /// Any dead cell with more less one live cell neighbors dies.
        /// </summary>
        [TestMethod]
        public void DeadCellMoreLessOneLiveCellNeighbors_1()
        {
            CellStatus currentstate = CellStatus.Dead;
            int liveNeighbors = 1;

            CellStatus nextGeneration = GameRules.GetNewState(currentstate, liveNeighbors);


            Assert.AreEqual(CellStatus.Dead, nextGeneration);

        }
    }
}