using System;
using System.Collections.Generic;
using System.Text;

namespace RAELOS
{
    class Screen
    {
        /*FIELDS TO PLOW
         * char[] datamap - Holds the screen memory
         * char[] drawbuffer - Stores data that is queued up to be executed by ScreenUpdateThread
         * int cpx - Cursor X Position
         * int cpy - Cursor Y Position
         */
        /*THREADS TO STITCH
         * ScreenUpdateThread - Handles updating the screen using 'datamap' as it's input.
         */
        /*SUBS TO BOT:
         * bool Init() - Initialise the display canvas with the default resolution
         * DrawCharacter(char) - Draws a character out on the screen
         * SetCursorPos(int, int) - Sets the next location to draw a character
         * SetCursorType(int) - Zero: No Cursor | One: Flat Cursor | Two: Block Cursor
         * SetCursorBlink(bool) - Controls if the cursor is blinking or not
         * Clear() - Clears the screen and resets the cursor position to (1,1)
         * Clear(bool) - Clears the screen but if false is set, it doesn't reset the cursor position and instead leaves it where it is.
         * Clear(char) - Clears the screen and fills it with a specific character.
         * DrawImage(Image) - Draws an image from the top left corner
         * DrawImage(Image, int, int) - Draws an image at the specified pixel coordinates. 
         * ConvertPos(bool, int, int) - If true, convert character pos to pixel. False is the other way around.
         * UpdateScreen() - Designed only for use in ScreenUpdateThread. Draws the datamap to the screen.
         */
    }
}
