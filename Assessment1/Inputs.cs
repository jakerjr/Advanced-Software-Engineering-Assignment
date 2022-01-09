using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment1
{
    class Inputs : Commands
    {

        public Inputs(String inputs)
        {
            String[] instructionSize = inputs.Split(null);
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
                        DrawTriangle(Int32.Parse(instructionSize[1]));
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
    }
}