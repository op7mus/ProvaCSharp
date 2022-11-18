using System;

double[] array = new double[]
{
    6.6, 7.2, 7.2, 8.4, 8.6, 8.4, 9.4, 9.8, 10.0
};
Console.WriteLine(mediaEspecial(array));

double mediaEspecial(double[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        array[i] = array[i+1];
    }
    array[array.Length] =0;
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
    return float.NaN;
}
