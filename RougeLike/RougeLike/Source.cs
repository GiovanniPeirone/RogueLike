using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    class Source
    {
        
            ConsoleKeyInfo keypress;
        int playerPosDefaultX = 3, playerPosDefaultY = 3;
        Character Player = new Character(
            100,
            "ü"
        );
        public void LevelGenerator()
        {

        }
        public void PlayerMovement()
        {


            Player.PrintCharacter(
                    playerPosDefaultX,
                    playerPosDefaultY
            );



            keypress = Console.ReadKey(true);

            if (keypress.Key == ConsoleKey.W && )
            {
                
                playerPosDefaultY--;
            }
            if (keypress.Key == ConsoleKey.S)
            {
                playerPosDefaultY++;
            }
            if (keypress.Key == ConsoleKey.A)
            {
                playerPosDefaultX--;
            }
            if (keypress.Key == ConsoleKey.D)
            {
                playerPosDefaultX++;
            }
        }
        public void Run()
        {
            while (true)
            {
                Console.CursorVisible = false;
                PlayerMovement();


                Thread.Sleep(10);
                Console.Clear();
            }
        }
    }
}
