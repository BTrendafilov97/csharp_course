using System;

namespace InheritanceDemo
{
    class ElecticalDevice
    {
        public bool IsOn{ get; set; }

        public string Brand{ get; set; }


        public ElecticalDevice(bool isOn, string brand)
        {
            isOn = IsOn;
            brand = Brand;
        }



        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwitchOff()
        {
            IsOn = false;
        }

        

    }
}