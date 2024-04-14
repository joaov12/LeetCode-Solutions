// Runtime 67 ms
// Memory 38.54 MB

public double[] ConvertTemperature(double celsius) 
{
    double kelvin = celsius + 273.15;
    double fahrenheit = celsius * 1.80 + 32.00;

    return[kelvin, fahrenheit];
}