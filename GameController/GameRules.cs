using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameController
{
    /// <summary>
    /// defines rules for game
    /// </summary>
    public class GameRules
    {
        #region Methods
        /// <summary>
        /// Checks cell die or live
        /// </summary>
        /// <param name="currentState"></param>
        /// <param name="liveNeighbors"></param>
        /// <returns></returns>
        public static CellStatus GetNewState(CellStatus currentState, int liveNeighbors)
        {
            switch (currentState)
            {
                case CellStatus.Alive:
                    if (liveNeighbors < 2 || liveNeighbors > 3)
                        return CellStatus.Dead;
                    break;
                case CellStatus.Dead:
                    if (liveNeighbors == 3)
                        return CellStatus.Alive;
                    break;
            }

            return currentState;
        } 
        #endregion
    }
}
