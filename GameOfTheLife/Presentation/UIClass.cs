using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GameOfTheLife.Logic;
using GameOfTheLife.Controlls;
using System.IO;
namespace GameOfTheLife
{
   public class UIClass
    {

        public static void ShowGrid(CellState[,] currentState)
        {
            Console.Clear();
            int x = 0;
            int rowLength = currentState.GetUpperBound(1) + 1;

            var output = new StringBuilder();

            foreach (var state in currentState)
            {
                output.Append(state == CellState.Alive ? "1" : ".");
                x++;
                if (x >= rowLength)
                {
                    x = 0;
                    output.AppendLine();
                }
            }
            //Console.Clear();
            Console.Write(output.ToString());
        }

        static void Main(string[] args)
        {
            EscapeControl.BackgroundColor();

            //GameGrid.readLineWithCancel();




            Console.WriteLine("Welcome to Game Of Life");

            Console.WriteLine("Choose size of Field :");

            int widthOfField = int.Parse(Console.ReadLine());

            int heightOfField = int.Parse(Console.ReadLine());

            var grid = new GameGrid(widthOfField, heightOfField);
            grid.RandomizationOfField();

            int iterations = 0;
            ShowGrid(grid.CurrentState);


            while (true)
            {

                grid.UpdateState();
                ShowGrid(grid.CurrentState);
                iterations++;
                //aliveCells.Sum();
                //Console.WriteLine($"Alive cells {grid.SumOfAliveCells()}");
                Console.WriteLine($"Iterations : {iterations}");
                Thread.Sleep(400);

            }


        }

        //static void InputTest(int x, int y)
        //{
         

        //    bool value = true;
        //    (x!=Not integer )
        //    then
        //   //     error x is not integer type train again 
        //   else{
        //        return x;
        //    }
        //}
    }
}

