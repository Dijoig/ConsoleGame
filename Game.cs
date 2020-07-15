using System;
using System.Data;
using System.Runtime.InteropServices;

namespace ConsoleGame
{
  class Game : SuperGame
  {
        //UpdatePosition methdo interacts with Program to make the cursor move
    public new static void UpdatePosition(string key, out int xChange, out int yChange)
        {
            xChange = 0;
            yChange = 0;
            switch (key)
            {
                case "DownArrow":
                    yChange++;
                    break;
                case "LeftArrow":
                    xChange--;
                    break;
                case "UpArrow":
                    yChange--;
                    break;
                case "RightArrow":
                    xChange++;
                    break;
                default:
                    break;

            }
        }

        //UpdateCursor method interacts with Program to make the cursor change depending he arrow pressed
        public new static char UpdateCursor(string key)
        {
            char cursor = '>';
            switch (key)
            {
                case "DownArrow":
                    cursor = 'v';
                    break;
                case "LeftArrow":
                    cursor = '<';
                    break;
                case "UpArrow":
                    cursor = '^';
                    break;
                case "RightArrow":
                    cursor = '>';
                    break;
            }
            return cursor;
        }

        //KeepInBounds method is called on Program to avoid the game from breaking if you try to move the cursor out of the boundaries of the console
        public new static int KeepInBounds(int dimension, int max)
        {
            int characterLocation = dimension;
            if (dimension >= max)
            {
                characterLocation = max - 1;
            } else if (dimension < 0)
            {
                characterLocation = 0;
            }
            return characterLocation;
        }

        //DidScore method is called on Program to update the score if the player hit the target(fruit @)
        public new static bool DidScore(int x1, int y1, int x2, int y2)
        {
            return (x1 == x2 && y1 == y2);
        }
    }

}