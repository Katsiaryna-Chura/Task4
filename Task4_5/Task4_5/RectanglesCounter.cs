using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5
{
    class RectanglesCounter
    {
        public static long GetCountOfRectangles(long totalWidth, long totalHeight, long rectWidth, long rectHeight)
        {
            return Math.Max(PackRectangles(totalWidth, totalHeight, rectWidth, rectHeight),PackRectangles(totalWidth, totalHeight, rectHeight, rectWidth));
        }

        public static long PackRectangles(long totalWidth, long totalHeight, long rectWidth, long rectHeight)
        {
            long number = ((totalWidth / rectWidth) | 0) * ((totalHeight / rectHeight) | 0);
            if(totalWidth % rectWidth >= rectHeight && totalHeight >= rectWidth)
            {
                number += PackRectangles(totalWidth % rectWidth, totalHeight, rectHeight, rectWidth);
            }
            else if (totalHeight % rectHeight >= rectWidth && totalWidth >= rectHeight)
            {
                number += PackRectangles(totalWidth, totalHeight % rectHeight, rectHeight, rectWidth);
            }
            return number;
        }
    }
}
