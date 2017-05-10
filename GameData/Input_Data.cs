using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    public class Input_Data
    {
        public int WidthSize { get; set; }
        public int HeightSize { get; set; }

        public Input_Data(int width, int height )
        {
            WidthSize = width;
            HeightSize = height;
        }
    public int Validsate_Data_Input()
        {
            if (WidthSize!=0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }  
    }
}
