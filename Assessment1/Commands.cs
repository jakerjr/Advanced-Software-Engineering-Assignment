using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.VisualBasic;

namespace Assessment1
{
    public class Commands
    {
        protected Graphics graphics;
        private Pen pen;
        protected int xPos, yPos; // Original position of the Pen
        private Boolean fillStatus = false; // Checks if fill is on
        private Brush brush;
        protected Boolean invalidCode; // Checks for valid code.
        protected Boolean parameterError; // Checks the parameter.
        private float newSpace = 0; // To fill any needed float variables
        private int xVariable;
        private int yVariable;
        protected int firstInput;
        protected int secondInput;
        protected Boolean variablePresent;
        protected Boolean xVariablePresent;
        protected Boolean yVariablePresent;

        /// <summary>
        /// Overloads the parameters when the class is initiated.
        /// </summary>
        /// <param name="graphics">Takes in a Graphics variable</param>
        public Commands(Graphics graphics)
        {
            this.graphics = graphics;
            xPos = yPos = 0;
            pen = new Pen(Color.Black, 1);
            brush = new SolidBrush(Color.Black);
        }

        protected Commands(){}

        /// <summary>
        /// Resets the Pen to the original position.
        /// </summary>
        protected void reset()
        {
            NewPosition(0,0);
        }

        /// <summary>
        /// Moves the pen to a new position.
        /// </summary>
        /// <param name="toX">X coordinate position.</param>
        /// <param name="toY">Y coordinate position.</param>
        protected void MoveTo(int toX, int toY)
        {
            NewPosition(toX, toY);
        }

        /// <summary>
        /// Clears the drawing area to a white screen
        /// </summary>
        protected void clear()
        {
            graphics.Clear(Color.White);
        }

        /// <summary>
        /// Draws a line from the original position to a new position.
        /// </summary>
        /// <param name="toX">The X coordinate of the line.</param>
        /// <param name="toY">The Y position of the line.</param>
        protected void DrawTo(int toX, int toY)
        {
            graphics.DrawLine(pen, xPos, yPos, toX, toY);
            NewPosition(toX, toY);
        }

        /// <summary>
        /// Draws a rectangle.
        /// </summary>
        /// <param name="toX">X coordinate to for the X position of the rectangle.</param>
        /// <param name="toY">Y coordinate to for the Y position of the rectangle.</param>
        protected void DrawRectangle(int toX, int toY)
        {
            Rectangle rectangle = new Rectangle(xPos, yPos, toX, toY);
            if (!fillStatus)
            {
                graphics.DrawRectangle(pen, rectangle.xPosition, rectangle.yPosition, rectangle.toX, rectangle.toY);
            }
            else
            {
                graphics.FillRectangle(brush, rectangle.xPosition, rectangle.yPosition, rectangle.toX, rectangle.toY);
            }
        }

        /// <summary>
        /// Draws a circle around the pen.
        /// </summary>
        /// <param name="radius">Takes in an integer for how big the circle will be.</param>
        protected void DrawCircle(int radius)
        {
            Circle circle = new Circle(xPos, yPos, radius);
            if (!fillStatus)
            {
                graphics.DrawEllipse(pen, circle.xPosition, circle.yPosition, circle.rad, circle.rad);
            }
            else
            {
                graphics.FillEllipse(brush, circle.xPosition, circle.yPosition, circle.rad, circle.rad);
            }
        }

        /// <summary>
        /// Draws a triangle around the pen.
        /// </summary>
        /// <param name="length">Takes in an integer for how long the triangle will be.</param>
        protected void DrawTriangle(int length)
        {
            Triangle triangle = new Triangle(length, xPos, yPos);
            Point[] point = { new Point (triangle.xPos, triangle.yPos - triangle.length / 2),
                new Point(triangle.xPos + triangle.length / 2, triangle.yPos + triangle.length / 2),
                new Point(triangle.xPos - triangle.length / 2, triangle.yPos + triangle.length / 2) };
            if (!fillStatus)
            {
                graphics.DrawPolygon(pen, point);
            }
            else
            {
                graphics.FillPolygon(brush, point);
            }
        }

        /// <summary>
        /// Changes the color of the pen and brush.
        /// </summary>
        /// <param name="setColor">Takes in a String. The String must be a valid color.</param>
        protected void ChangePenColor(String setColor)
        {
            pen.Color = Color.FromName(setColor);
            brush = new SolidBrush(Color.FromName(setColor));
        }

        /// <summary>
        /// Fill command. Used to enable or disable shape filling.
        /// </summary>
        /// <param name="status">Takes in a String. The String result can only be on or off.</param>
        protected void Fill(String status)
        {
            if(status.Equals("on"))
            {
                fillStatus = true;
            }
            else if (status.Equals("off"))
            {
                fillStatus = false;
            }
        }

        protected void SetXPos(int xVariable)
        {
            this.xVariable = xVariable;
            variablePresent = true;
            xVariablePresent = true;
        }

        protected void SetYPos(int yVariable)
        {
            this.yVariable = yVariable;
            variablePresent = true;
            yVariablePresent = true;
        }

        protected void TwoInputs(String[] position)
        {
            try
            {
                for (int x = 0; x < position.Length; x++)
                {
                    int xVariablePos = Array.IndexOf(position, "x");
                    int yVariablePos = Array.IndexOf(position, "y");

                    if (int.TryParse(position[x], out int value))
                    {
                        if (position.Length == 3)
                        {
                            firstInput = Int32.Parse(position[1]);
                            secondInput = Int32.Parse(position[2]);
                        }
                    }
                    else if (position[x].Equals("x"))
                    {
                        if (xVariablePos == 1)
                        {
                            firstInput = xVariable;
                        }
                        else if (xVariablePos == 2)
                        {
                            secondInput = xVariable;
                        }
                        else if (xVariablePos == 1 && xVariablePos == 2)
                        {
                            xVariable = 100;
                            firstInput = xVariable;
                            secondInput = xVariable;
                        }
                    }
                    else if (position[x].Equals("y"))
                    {
                        if (yVariablePos == 1)
                        {
                            firstInput = yVariable;
                        }
                        else if (yVariablePos == 2)
                        {
                            secondInput = yVariable;
                        }
                        else if (yVariablePos == 1 && yVariablePos == 2)
                        {
                            firstInput = yVariable;
                            secondInput = yVariable;
                        }
                    }
                }
            }
            catch (Exception)
            {
               Console.WriteLine("e"); 
            }

        }

        /// <summary>
        /// Processes variables and outputs a value
        /// </summary>
        /// <param name="position">takes in a string array</param>
        protected void singleInput(String[] position)
        {
            try
            {
                for (int x = 0; x < position.Length; x++)
                {
                    int xVariablePos = Array.IndexOf(position, "x");
                    int yVariablePos = Array.IndexOf(position, "y");

                    if (int.TryParse(position[x], out int value))
                    {
                        if (position.Length == 2)
                        {
                            firstInput = Int32.Parse(position[1]);
                        }
                    }
                    else if (position[x].Equals("x"))
                    {
                        if (xVariablePos == 1)
                        {
                            firstInput = xVariable;
                        }
                    }
                    else if (position[x].Equals("y"))
                    {
                        if (yVariablePos == 1)
                        {
                            firstInput = yVariable;
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("e");
            }
        }

        /// <summary>
        /// Executes the commands.
        /// </summary>
        /// <param name="instruction">Takes in a String. The string will allow a user to interact with the program.</param>
        public void executeCommands(String instruction)
        {
            String[] instructionSize = instruction.Split(null);
            // simple exception handling to capture invalid parameters
            try
            {
                // if else statements to handle command operations and error checking
                if (instructionSize[0].Equals("rect"))
                {
                    if (instructionSize.Length == 3)
                    {
                        TwoInputs(instructionSize);
                        DrawRectangle(firstInput, secondInput);
                    }
                    else
                    {
                        parameterError = true;
                    }
                }
                else if (instructionSize[0].Equals("triangle"))
                {
                    if (instructionSize.Length == 2)
                    {
                        singleInput(instructionSize);
                        DrawTriangle(firstInput);
                    }
                    else
                    {
                        parameterError = true;
                    }
                }
                else if (instructionSize[0].Equals("circle"))
                {
                    if (instructionSize.Length == 2)
                    {
                        DrawCircle(Int32.Parse(instructionSize[1]));
                    }
                    else
                    {
                        parameterError = true;
                    }
                }
                else if (instructionSize[0].Equals("drawto"))
                {
                    if (instructionSize.Length == 3)
                    {
                        DrawTo(Int32.Parse(instructionSize[1]), Int32.Parse(instructionSize[2]));
                    }
                    else
                    {
                        parameterError = true;
                    }
                }
                else if (instructionSize[0].Equals("reset"))
                {
                    reset();
                }
                else if (instructionSize[0].Equals("moveto"))
                {
                    if (instructionSize.Length == 3 && !variablePresent)
                    {
                        MoveTo(Int32.Parse(instructionSize[1]), Int32.Parse(instructionSize[2]));
                    }
                    else
                    {
                        parameterError = true;
                    }
                }
                else if (instructionSize[0].Equals("clear"))
                {
                    clear();
                }
                else if (instructionSize[0].Equals("fill"))
                {
                    Fill(instructionSize[1]);
                }
                else if (instructionSize[0].Equals("pen"))
                {
                    ChangePenColor(instructionSize[1]);
                }
                else if (instructionSize[0].Equals("x"))
                {
                    SetXPos(Int32.Parse(instructionSize[1]));
                }
                else if (instructionSize[0].Equals("y"))
                {
                    SetYPos(Int32.Parse(instructionSize[1]));
                }
                else
                {
                    invalidCode = true;
                }
            } 
            catch (Exception)
            {
                parameterError = true;
            }
        }

        /// <summary>
        /// Prints text on the graphics window
        /// </summary>
        /// <param name="test">The text that will be printed on the window</param>
        private void DrawString(String msg)
        {
            Font font = new Font("Arial", 16);
            graphics.DrawString(msg, font, brush, 0, newSpace);
        }

        /// <summary>
        /// Checks for any errors then prints it on the graphics area.
        /// </summary>
        /// <param name="errorLine">Shows which line the error is in.</param>
        public void CommandError(int errorLine)
        {
            if (invalidCode) // checks for invalid commands
            {
                errorLine++;
                newSpace += 16;
                invalidCode = false;
                DrawString("Invalid Code Line: " + errorLine);
            }
            else if (parameterError) // checks for invalid parameters
            {
                errorLine++;
                newSpace += 16;
                parameterError = false;
                DrawString("Wrong Parameter Line: " + errorLine);
            }

        }

        /// <summary>
        /// A simple method to reposition the pen.
        /// </summary>
        /// <param name="x">New X coordinate of the pen.</param>
        /// <param name="y">New Y coordinate of the pen.</param>
        private void NewPosition(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

    }
}
