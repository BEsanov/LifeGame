using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameController
{
   public class Field
    {
        public int heightOfField { get; set; }
        public int widthOfField { get; set; }

        public Field(int height, int width)
        {
            this.heightOfField = height;
            this.widthOfField = width;
        }

    }
}
