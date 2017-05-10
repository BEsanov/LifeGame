using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GameOfTheLife.Logic;
using System.IO;

namespace GameOfTheLife
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Game Of Life");



            Console.WriteLine("Choose size of Field :");
            int widthOfField = int.Parse(Console.ReadLine());
            int heightOfField = int.Parse(Console.ReadLine());



            var grid = new LifeGrid(widthOfField, heightOfField);
            grid.RandomizationOfField();

            int iterations = 0;
          

          
            

            ShowGrid(grid.CurrentState);

            //Task task1 = new Task(() =>
            //  {
            //      var iterateEachSecond = Console.ReadLine();





            while (true/*Console.ReadLine() != "q"*/)
            {

                grid.UpdateState();
                ShowGrid(grid.CurrentState);
                iterations++;
                //aliveCells.Sum();
                //Console.WriteLine($"Alive cells {grid.SumOfAliveCells(widthOfField,heightOfField)}");
                Console.WriteLine($"Iterations : {iterations}");
                Thread.Sleep(2000);




            }

            //Console.WriteLine(" =================================");
            //Console.WriteLine("Press press space to exit from game ");
            //Console.ReadKey();

            //  });

            //task1.Start();







        }


        /*=====================================================*/

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

        }
        /*=====================================================*/




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

        //THIS WAS A SLOW DISPLAY ON LARGE GRIDS
        //private static void ShowGrid(CellState[,] currentState)
        //{
        //    Console.Clear();
        //    int x = 0;
        //    int rowLength = currentState.GetUpperBound(1) + 1;

        //    foreach (var state in currentState)
        //    {
        //        var output = state == CellState.Alive ? "O" : "·";
        //        Console.Write(output);
        //        x++;
        //        if (x >= rowLength)
        //        {
        //            x = 0;
        //            Console.WriteLine();
        //        }
        //    }
        //}
    }
}

