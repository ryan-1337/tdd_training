package com.example;

public class Thermometer
{
    public int Generate(int[] array) {
        if (array.length == 0 || array.length > 10000) {
            return 0;
        }

        int temperatureClosestToZero = array[0];

        for (int temperature : array) {
            if(Math.abs(temperature) < Math.abs(temperatureClosestToZero)) {
                temperatureClosestToZero = temperature;
            }
        }

        return temperatureClosestToZero;
    }
}
