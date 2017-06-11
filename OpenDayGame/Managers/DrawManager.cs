using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDayGame.Managers
{
    class DrawManager
    {
        private int XSize = 29;
        private int YSize = 19;

        private char[,] onScreen, toScreen;
        public DrawManager()
        {
            Console.SetWindowSize(XSize, YSize);
            Console.SetBufferSize(XSize, YSize);
            Console.CursorVisible = false;

            onScreen = new char[XSize, YSize];
            toScreen = new char[XSize, YSize];
        }

        public void DrawToScreen()
        {
            if (YSize != Console.WindowHeight || XSize != Console.WindowWidth || YSize != Console.BufferHeight || XSize != Console.BufferWidth)
            {
                try
                {
                    Console.Clear();
                    onScreen = new char[XSize, YSize];
                    Console.SetWindowSize(XSize, YSize);
                    Console.SetBufferSize(XSize, YSize);
                    Console.CursorVisible = false;
                }
                catch (Exception) { }
                return;
            }

            for (int j = 0; j < YSize; j++)
            {
                for (int i = 0; i < XSize; i++)
                {
                    if (onScreen[i, j] != toScreen[i, j])
                    {
                        try
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write(toScreen[i, j]);
                            onScreen[i, j] = toScreen[i, j];
                        }
                        catch (Exception) { }
                    }
                }
            }

            onScreen = toScreen;
            toScreen = new char[XSize, YSize];
        }

        public bool setChar(Char character, UInt32 color, int X, int Y)
        {
            if (X >= XSize || Y >= YSize || X < 0 || Y < 0)
                return false;

            toScreen[X, Y] = character;
            return true;
        }

        public bool getChar(out Char character, out UInt32 color, int X, int Y)
        {
            if (X >= XSize || Y >= YSize || X < 0 || Y < 0)
            {
                character = (Char)0;
                color = 0;
                return false;
            }

            long temp = toScreen[X, Y];
            character = (Char)(temp >> 32);
            color = (UInt32)(temp & 0xffffffff);
            return true;
        }
    }
}
