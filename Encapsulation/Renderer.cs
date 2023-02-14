using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Renderer
    {
        public void Draw(int x, int y, char character = '@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(character);
            Console.ReadKey(true);
        }
    }
}
