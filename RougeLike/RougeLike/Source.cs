using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    class Source
    {
        public void Run()
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo keypress;
            int playerPosDefaultX = 3, playerPosDefaultY = 3;
            Character Player = new Character(
                playerPosDefaultY,
                playerPosDefaultX,
                100,
                "ü"
            );


            do
            {

            } while ( true );

            while (true)
            {
                

                Player.PrintCharacter();

                keypress = Console.ReadKey(true);

                if (keypress.Key == ConsoleKey.W) 
                { 
                    layerPosDefaultY++; 
                }
                if (keypress.Key == ConsoleKey.S) { playerPosDefaultY--; }
                if (keypress.Key == ConsoleKey.A) { playerPosDefaultX--; }
                if (keypress.Key == ConsoleKey.D) { playerPosDefaultX++; }

                Console.Clear();
            }
        }

        public void LevelGenerator()
        {

        }
    }
}
