using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        /// <summary>
        /// Конструктор
        /// Принцип инкапсуляции
        /// </summary>
        /// <param name="_x">координата х</param>
        /// <param name="_y">координата у</param>
        /// <param name="_sym">символ точки</param>
        public Point(int _x, int _y, char _sym)   
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
