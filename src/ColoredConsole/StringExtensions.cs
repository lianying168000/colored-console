﻿// <copyright file="StringExtensions.cs" company="ColoredConsole contributors">
//  Copyright (c) ColoredConsole contributors. (coloredconsole@gmail.com)
// </copyright>

namespace ColoredConsole
{
    using System;

    /// <summary>
    /// Convenience extension methods for colorizing strings.
    /// </summary>
    public static class StringExtensions
    {
        public static ColorToken Color(this string text, ConsoleColor? color = null)
        {
            return new ColorToken(text, color);
        }

        public static ColorToken Black(this string text)
        {
            return text.Color(ConsoleColor.Black);
        }

        public static ColorToken Blue(this string text)
        {
            return text.Color(ConsoleColor.Blue);
        }

        public static ColorToken Cyan(this string text)
        {
            return text.Color(ConsoleColor.Cyan);
        }

        public static ColorToken DarkBlue(this string text)
        {
            return text.Color(ConsoleColor.DarkBlue);
        }

        public static ColorToken DarkCyan(this string text)
        {
            return text.Color(ConsoleColor.DarkCyan);
        }

        public static ColorToken DarkGray(this string text)
        {
            return text.Color(ConsoleColor.DarkGray);
        }

        public static ColorToken DarkGreen(this string text)
        {
            return text.Color(ConsoleColor.DarkGreen);
        }

        public static ColorToken DarkMagenta(this string text)
        {
            return text.Color(ConsoleColor.DarkMagenta);
        }

        public static ColorToken DarkRed(this string text)
        {
            return text.Color(ConsoleColor.DarkRed);
        }

        public static ColorToken DarkYellow(this string text)
        {
            return text.Color(ConsoleColor.DarkYellow);
        }

        public static ColorToken Gray(this string text)
        {
            return text.Color(ConsoleColor.Gray);
        }

        public static ColorToken Green(this string text)
        {
            return text.Color(ConsoleColor.Green);
        }

        public static ColorToken Magenta(this string text)
        {
            return text.Color(ConsoleColor.Magenta);
        }

        public static ColorToken Red(this string text)
        {
            return text.Color(ConsoleColor.Red);
        }

        public static ColorToken White(this string text)
        {
            return text.Color(ConsoleColor.White);
        }

        public static ColorToken Yellow(this string text)
        {
            return text.Color(ConsoleColor.Yellow);
        }
    }
}
