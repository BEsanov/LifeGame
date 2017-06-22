using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace GameController.Entities
{
    /// <summary>
    /// Validating user input
    /// </summary>
    public class InputByUser
    {
        #region Methods
        /// <summary>
        /// Validate users input, if it is integer or not
        /// </summary>
        /// <returns></returns>
        public int ValidateUserInput()
        {
            string input;

            int x;

            input = Console.ReadLine();

            while (!Int32.TryParse(input, out x))
            {
                Console.WriteLine("Not a valid number, try again.");

                input = Console.ReadLine();
            }
            return x;

        } 
        #endregion

    }

}

