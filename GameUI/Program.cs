using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameController;
using System.Threading;
using GameController.Entities;
using System.ComponentModel;
using GameController.Game_Contol;
namespace GameUI
{
    public class UIClass
    {
        static void Main(string[] args)
        {
            InputByUser iu = new InputByUser();

            Console.WriteLine("Welcome to Game Of Life");
            Console.WriteLine("Enter Fields heigth ");
            int x = iu.ValidateUserInput();
            Console.WriteLine("Enter Fields width ");
            int y = iu.ValidateUserInput();

            GamesController gc = new GamesController();

            Thread trd = new Thread(() => gc.Actions(x, y));
            trd.Start();

        }
    }
}



