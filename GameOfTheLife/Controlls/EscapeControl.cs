using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace GameOfTheLife.Controlls
{
    public class EscapeControl
    {



        public static void BackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
        }

        //Thread ConsoleKeyListener = new Thread(new ThreadStart(ListenKeyFromKeyboard));

        public static void ReadEscape()
        {
            var taskKeys = new Task(ReadEscape);
            taskKeys.Start();
            var tasks = new[] { taskKeys };
            Task.WaitAll(tasks);
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            while (!Console.KeyAvailable && key.Key != ConsoleKey.Escape)
            {

                key = Console.ReadKey(true);

                switch (key.Key)
                {


                    case ConsoleKey.Escape:
                        break;

                    default:
                        if (Console.CapsLock && Console.NumberLock)
                        {
                            Console.WriteLine(key.KeyChar);
                        }
                        break;
                }
            }
        }
    }
}
