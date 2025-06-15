package com.example;

import org.junit.jupiter.api.Test;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;

import static org.junit.jupiter.api.Assertions.assertEquals;


public class ThermometreTest {

    private final Thermometre thermometre = new Thermometre();

    @Test
    void Should_ReturnZero_When_thermometre_is_null_or_empty() {
        assertEquals(0, thermometre.Generate(new int[0]));
    }

    @Test
    void Should_ReturnZero_When_thermometre_value_more_than_ten_thousandth() {
        int[] values = new int[10001];
        for (int i = 0; i < 10001; i++) {
            values[i] = i++;
        }

        assertEquals(0, thermometre.Generate(values));
    }

}
