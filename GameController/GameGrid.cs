﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameController
{
    public class GameGrid
    {
        public int gridHeight { get; set; }
        public int gridWidth { get; set; }

        public CellState[,] CurrentState;
        private CellState[,] nextState;

        public GameGrid(int height, int width)
        {
            gridHeight = height;
            gridWidth = width;

            CurrentState = new CellState[gridHeight, gridWidth];
            nextState = new CellState[gridHeight, gridWidth];

            for (int i = 0; i < gridHeight; i++)
                for (int j = 0; j < gridWidth; j++)
                {
                    CurrentState[i, j] = CellState.Dead;
                }
        }

        public void UpdateState()
        {
            for (int i = 0; i < gridHeight; i++)
                for (int j = 0; j < gridWidth; j++)
                {
                    var liveNeighbors = GetLiveNeighbors(i, j);
                    nextState[i, j] =
                        GameRules.GetNewState(CurrentState[i, j], liveNeighbors);
                }

            CurrentState = nextState;
            nextState = new CellState[gridHeight, gridWidth];
        }



        public void RandomizationOfField()
        {
            Random random = new Random();

            for (int i = 0; i < gridHeight; i++)
                for (int j = 0; j < gridWidth; j++)
                {
                    var next = random.Next(2);
                    var newState = next < 1 ? CellState.Dead : CellState.Alive;
                    CurrentState[i, j] = newState;
                }
        }

        private int GetLiveNeighbors(int positionX, int positionY)
        {
            int liveNeighbors = 0;
            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    int neighborX = positionX + i;
                    int neighborY = positionY + j;

                    if (neighborX >= 0 && neighborX < gridHeight &&
                        neighborY >= 0 && neighborY < gridWidth)
                    {
                        if (CurrentState[neighborX, neighborY] == CellState.Alive)
                            liveNeighbors++;
                    }
                }

            return liveNeighbors;
        }




        public int SumOfAliveCells()
        {
            int total = 0;

            CellState cell = CellState.Alive;
            for (int i = 0; i < gridWidth; i++)
            {
                for (int j = 0; j < gridHeight; j++)

                    if (cell.Equals('1'))
                    {
                        total += 1;
                    }

            }
            return total;
        }
    }
}