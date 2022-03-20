using System;

namespace InheritanceDemo
{
    class TV : ElecticalDevice
    {
        public TV(bool isOn, string brand):base(isOn,brand)
        {

        }
        public void WatchTV()
        {
            if (IsOn)
            {
                System.Console.WriteLine("Watching the TV");
            }
            else
            {
                System.Console.WriteLine("TV is switch off, try switcing on frist.");
            }
        }
    }
}