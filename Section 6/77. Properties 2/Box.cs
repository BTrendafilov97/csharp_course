using System;

namespace Classes_basics
{
    class Box
    {
        // member variables
        private int volume;
        private int lenght = 3,height;

        public int Width { get; set; }
        public int Volume
        {
            get
            {
                return this.lenght*this.height*this.Width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                this.height = value;
            }
        }

        public Box(int lenght, int height, int width)
        {
            this.lenght = lenght;
            this.height = height;
            Width = width;
        }
        public void SetLenght(int lenght)
        {
            this.lenght = lenght;
        }

        public int GetLenght()
        {
            return this.lenght;
        }

        public int FrontSurface 
        { 
            get
            {
                this.height*this.lenght;
            }  
        }
        public async void DisplayInfo()
        {
            Console.WriteLine("Lenight is {0}, height is {1}, width is {2} so the volume is {3}"
            ,lenght,height,width,volume = lenght*width*height);
        }
    }
}