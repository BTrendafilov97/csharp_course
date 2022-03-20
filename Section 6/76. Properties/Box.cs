using System;

namespace Classes_basics
{
    class Box
    {
        // member variables
        public int height,width,volume;
        private int lenght = 3;


        public void SetLenght(int lenght)
        {
            this.lenght = lenght;
        }

        public int GetLenght()
        {
            return this.lenght;
        }
        public async void DisplayInfo()
        {
            Console.WriteLine("Lenight is {0}, height is {1}, width is {2} so the volume is {3}"
            ,lenght,height,width,volume = lenght*width*height);
        }
    }
}