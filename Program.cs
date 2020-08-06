using System;
using System.Collections.Generic;

namespace boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> Box = new List<object>();
            Box.Add(7);
            Box.Add(28);
            Box.Add(-1);
            Box.Add(true);
            Box.Add("chair");
            int sum = 0;
            for(int i = 0; i<Box.Count; i++){
                Console.WriteLine(Box[i]);
                if (Box[i] is int){
                    sum = sum + (int)Box[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
