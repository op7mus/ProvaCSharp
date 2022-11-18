using System.Collections.Generic;
using System;

App.Run();

public class BluerControl
{   
    public void ApplyBlur(byte[] data)
    {
        byte sum=0;
        List<byte> arr = new List<byte>();

        for (int i = 0; i < data.Length; i++)
        {
            if(i>20 && i<data.Length-20)
            {
                sum = data[i];
                for (int j = 0; j < 20; j++)
                {
                    
                    arr.Add(data[i-j]);
                    arr.Add(data[i+j]);
                }
                foreach (var item in arr)
                {
                    sum += item;
                }
                sum = (byte)(sum / 41);
                data[i]=(byte)sum;
            }
            
            Console.WriteLine(sum);
        }
    }
}