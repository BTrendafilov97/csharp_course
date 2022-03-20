using System;
using System.Collections;
using System.Collections.Generic;

namespace ArraysSection
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Declaring array list
            ArrayList myArrayList = new ArrayList();

            //with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);

            // delete specific element
            myArrayList.Remove(13);

            // delete element on specific position
            myArrayList.RemoveAt(0);

            System.Console.WriteLine(myArrayList.Count);
            
            double sum = 0;

            foreach (object item in myArrayList)
            {
                if (item is int)
                {
                    sum += Convert.ToDouble(item);
                }else if (item is double)
                {
                    sum += (double)item;
                }
                else if (item is string)
                {
                    System.Console.WriteLine(item);
                }
            }

            System.Console.WriteLine(sum);


            
        }
        
    }
}