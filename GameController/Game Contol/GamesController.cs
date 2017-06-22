using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameController.Game_Contol
{
    /// <summary>
    /// Game control by user
    /// </summary>
    public class GamesController
    {
        #region Fields 
        private static bool isPaused = false;
        #endregion Properties

        #region Methods
        /// <summary>
        /// Creates game grid 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Actions(int x, int y)
        {

            var grid = new GameGrid(x, y);
            grid.RandomizationOfField();

            int iterations = 0;
            Graphics.ShowGrid(grid.CurrentState);
            Console.SetWindowSize(x, y + 2);

            Thread userInputReader = new Thread((UserController));

            userInputReader.Start();

            while (true)
            {
                if (!isPaused)
                {
                    grid.UpdateState();
                    Graphics.ShowGrid(grid.CurrentState);

                    iterations++;
                    Console.WriteLine($"Iterations : {iterations}");
                    Thread.Sleep(400);
                    //GamesController gm = new GamesController();

                }
            }
        }
        /// <summary>
        /// Controls game ontrol by user.
        /// </summary>
        public void UserController()
        {
            while (true)
            {
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.Spacebar)//
                {
                    isPaused = true;
                }
                else if (key.Key == ConsoleKey.R)//Run
                {
                    isPaused = false;
                }
                else if (key.Key == ConsoleKey.Escape)//Exit Game
                {
                    Environment.Exit(0);
                }
            }
        } 
        #endregion

    }
}
