using System;

namespace Classes_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Height = 4;
            box.width = 5;
            box.SetLenght(4);

            box.DisplayInfo();
        }
    }
}