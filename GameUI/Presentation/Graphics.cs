using GameController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUI.Presentation
{
    /// <summary>
    /// 
    /// </summary>
    public class Graphics
    {
        #region Fields

        /// <summary>
        /// 
        /// </summary>
        public static bool _cancelled = false;

        #endregion Fields

        #region Properties
        #endregion Properties

        #region Constructors
        #endregion Constructors

        #region Methods

        /// <summary>
        /// Shows fied
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
            // todo: Console.SetCursorPosition(); to update only changesf


        }

       
        #endregion Methods
    }
}
