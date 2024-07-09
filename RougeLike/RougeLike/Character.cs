using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    class Character
    {
        public int Life;
        public string Sprite;

        public Character( 
            int life,
            string sprite)
        {
            Life = life;
            Sprite = sprite;
        }
        
        public void PrintCharacter(int PosX,int PosY)
        {
            Console.SetCursorPosition(PosX,PosY);
            Console.WriteLine(Sprite);
        }
    }
}
