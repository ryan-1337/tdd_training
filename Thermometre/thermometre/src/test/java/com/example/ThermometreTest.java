package com.example;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;


public class ThermometreTest {

    @Test
    void Should_ReturnZero_When_thermometre_is_null() {
        Thermometre thermometre = new Thermometre();
        assertEquals(0, thermometre.Generate());
    }

}
