using System.Collections.Generic;
using System;

App.Run();

public class BluerControl
{   
    public int[] arr;
    public void ApplyBlur(byte[] data)
    {
        int sum=0;

        for (int i = 0; i < data.Length; i++)
        {
            if(i>20 && i<data.Length-20)
            {
                sum = data[i];
                for (int j = 1; j < 21; j++)
                    arr[j] = (int)data[i-j];
                
                for (int j = 1; j < 21; j++)
                    arr[j] = (int)data[i+j];
                
                foreach (var item in arr)
                    sum += item;
                
                sum = sum / 41;
                data[i]=(byte)sum;
            }
            
            Console.WriteLine(sum);
        }
    }
}