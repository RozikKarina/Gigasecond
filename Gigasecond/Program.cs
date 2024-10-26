﻿using System;

public static class Gigasecond
{
    private const int GigasecondInSeconds = 1_000_000_000;

    public static DateTime Add(DateTime moment)
    {
        // Додаємо гіга-секунду до початкового моменту часу
        return moment.AddSeconds(GigasecondInSeconds);
    }
}