using GameController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameController.Game_Contol
{/// <summary>
/// Demontrates cell live or dead 
/// </summary>
    public class Graphics
    {

        #region Methods
        /// <summary>
        /// Demonstrate grid according to user inputs: height and width
        /// </summary>
        /// <param name="currentState">uses current state of Cellstatus</param>
        public static void ShowGrid(CellStatus[,] currentState)
        {
            Console.SetCursorPosition(0, 0);
            int x = 0;
            int rowLength = currentState.GetUpperBound(1) + 1;

            var output = new StringBuilder();

            foreach (var state in currentState)
            {
                output.Append(state == CellStatus.Alive ? "1" : ".");
                x++;
                if (x >= rowLength)
                {
                    x = 0;
                    output.AppendLine();
                }
            }

            Console.Write(output.ToString());



        } 
        #endregion
    }
}

