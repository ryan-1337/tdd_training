package com.example;
import org.junit.jupiter.api.Test;
import java.util.Arrays;
import static org.junit.jupiter.api.Assertions.assertEquals;

public class ThermometerTest {

    private final Thermometer thermometre = new Thermometer();

    @Test
    void Should_ReturnZero_When_thermometre_is_null_or_empty() {
        //given an empty array of int
        int[] values = new int[0];

        //when the thermometer equal 0

        //then should return 0
        assertEquals(0, thermometre.Generate(new int[0]));
    }

    @Test
    void Should_ReturnZero_When_thermometre_value_more_than_ten_thousandth() {
        //given an array of int with 10001 values
        int[] values = new int[10001];

        //when the thermometer values is more than 10000
        for (int i = 0; i < 10001; i++) {
            values[i] = i++;
        }

        //then should return 0
        assertEquals(0, thermometre.Generate(values));
    }

    @Test
    void Should_Return_the_given_value() {
        //given an int array
        int[] values = {1};

        //when the value equal 1
        int response = thermometre.Generate(values);

        //then should return 1
        int value = values[0];
        assertEquals(value, response);
    }

    @Test
    void Should_Return_the_value_closest_to_zero() {
        //given an array with 4 values
        int[] values = {4,6, 5, 3};

        //when the thermometer have a good values
        int response = thermometre.Generate(values);

        //then should return the closest value
        assertEquals(3, response);
    }

    @Test
    void Should_Return_the_positive_value_closest_to_zero_When_value_are_same_positive_and_negative() {
        //given an array with four values with same negative and positive values
        int[] values = {2, 9, -2, -3};

        //when the thermometer have a good values
        int response = thermometre.Generate(values);

        //then should return the closest value positive
        assertEquals(2, response);
    }

    @Test
    void Should_Return_the_positive_value_closest_to_zero_When_value_are_same() {
        //given an array with two values
        int[] values = {-5, 5};

        //when the thermometer have a good values
        int response = thermometre.Generate(values);

        //then should return the closest value positive
        assertEquals(5, response);
    }
}
