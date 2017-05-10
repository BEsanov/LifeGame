using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfTheLife.Logic;

namespace GameOfTheLife.Tests
{
    [TestClass]
    public class GameRuleTest
    {


        /// <summary>
        /// Any live cell with fewer than two live neighbors dies.
        /// </summary>

        [TestMethod]
        public void Any_Live_Cell_With_Neighbours_0()
        {

            CellState currentState = CellState.Alive;
            int liveNeighbors = 0;

            CellState result = GameRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void Any_Live_Cell_With_Neighbours_1()
        {
            CellState currentStat = CellState.Alive;
            int liveNeigbors = 1;

            CellState result = GameRules.GetNewState(currentStat, liveNeigbors);

            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void AnyLiveCellWithTwoNeighbors_2()
        {
            CellState currentstate = CellState.Alive;
            int liveNeighbors = 2;

            CellState result = GameRules.GetNewState(currentstate, liveNeighbors);

            Assert.AreEqual(CellState.Alive, result);
        }


        [TestMethod]
        public void AnyLiveCellWithThreeNeighbors_3()
        {
            CellState curentstate = CellState.Alive;

            int liveNeighbors = 3;

            CellState result = GameRules.GetNewState(curentstate, liveNeighbors);

            Assert.AreEqual(CellState.Alive, result);
        }

        [TestMethod]
        public void AnyLiveCellWithFourNeigbors_4()
        {
            CellState currentState = CellState.Alive;
            int liveNeighbors = 4;

            CellState result = GameRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, result);

        }

        [TestMethod]
        public void AnyCellWithWithFiveNeighbors_5()
        {
            CellState currentState = CellState.Alive;
            int liveCells = 5;

            CellState resultForNextIteration = GameRules.GetNewState(currentState, liveCells);

            Assert.AreEqual(CellState.Dead, resultForNextIteration);
        }

        [TestMethod]
        public void AnyLiveCellWithSixNeigbors_6()
        {
            CellState currentState = CellState.Alive;
            int liveNeighbors = 6;

            CellState nextIteration = GameRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, nextIteration);


        }

        [TestMethod]
        public void DeadCellNoLiveNeighbors_0()
        {
            CellState current = CellState.Dead;
            int liveNeighbors = 0;

            CellState nextGeneration = GameRules.GetNewState(current, liveNeighbors);


            Assert.AreEqual(CellState.Dead, nextGeneration);

        }


        [TestMethod]
        public void DeadCellMoreLessOneLiveCellNeighbors_1()
        {
            CellState currentstate = CellState.Dead;
            int liveNeighbors = 1;

            CellState nextGeneration = GameRules.GetNewState(currentstate, liveNeighbors);


            Assert.AreEqual(CellState.Dead, nextGeneration);

        }
    }
}