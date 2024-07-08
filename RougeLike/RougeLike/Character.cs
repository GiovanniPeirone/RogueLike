using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    class Character
    {
        public int PosX;
        public int PosY;
        public int Life;
        public string Sprite;

        public Character(
            int _PosY,
            int _PosX, 
            int life,
            string sprite)
        {
            PosY = _PosY;
            PosX = _PosX;
            Life = life;
            Sprite = sprite;
        }
        
        public void PrintCharacter()
        {
            Console.SetCursorPosition(PosX,PosY);
            Console.WriteLine(Sprite);
        }
    }
}
