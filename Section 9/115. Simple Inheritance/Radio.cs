using System;

namespace InheritanceDemo
{
    class Radio : ElecticalDevice
    {

        public Radio(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void ListenRadio()
        {
            if (IsOn)
            {
                System.Console.WriteLine("Listening to the Radio");
            }
            else
            {
                System.Console.WriteLine("Radio is switch off, try switcing on frist.");
            }
        }
    }
}