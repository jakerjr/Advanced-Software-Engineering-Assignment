using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment1
{

    /// <summary>
    /// Rectangle class is used to calculate and output integers to draw a rectangle.
    /// </summary>
    class Rectangle
    {
        public int xPosition;
        public int yPosition;
        public int toX;
        public int toY;

        public Rectangle(int xPos, int yPos, int toX, int toY)
        {
            int newXPos = xPos + toX;
            int newYPos = yPos + toY;

            xPosition = xPos;
            yPosition = yPos;
            this.toX = newXPos;
            this.toY = newYPos;
        }
    }
}
