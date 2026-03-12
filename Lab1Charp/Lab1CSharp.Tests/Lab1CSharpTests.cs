using Xunit;
using System;
using System.IO;
using Lab1CSharp; 

public class Lab1CSharpTests
{
    [Fact]
    public void Task1_CalculatesCorrectRadius()
    {
        var input = new StringReader("10");
        Console.SetIn(input);

        double result = Program.Task1();

        Assert.Equal(1.59155, result, 5); // Радіус має бути 1 при довжині 2π
    }

    [Theory]
    [InlineData("351", "Перша цифра бiльше")]
    [InlineData("153", "Остання цифра бiльше")]
    [InlineData("252", "Цифри однаковi")]
    public void Task2_ComparesDigitsCorrectly(string mockInput, string expected)
    {
        Console.SetIn(new StringReader(mockInput));

        string result = Program.Task2();

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("10,20", "Точка потрапляє в область (Так)")]
    [InlineData("80,90", "Точка не потрапляє в область (Нi)")]
    [InlineData("50,50", "Точка знаходиться на межi")]
    public void Task3_ChecksPointInArea(string mockInput, string expected)
    {
        Console.SetIn(new StringReader(mockInput));

        string result = Program.Task3();

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("95", "Результат: вiдмiнно")]
    [InlineData("75", "Результат: добре")]
    [InlineData("30", "Результат: незадовiльно")]
    public void Task4_ReturnsCorrectGrade(string mockInput, string expected)
    {
        Console.SetIn(new StringReader(mockInput));

        string result = Program.Task4();

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Task5_CalculatesSquareOfSum()
    {
        // Емулюємо введення двох чисел (кожне з нового рядка)
        Console.SetIn(new StringReader("2\n3"));

        double result = Program.Task5();

        Assert.Equal(25.0, result); // (2+3)^2 = 25
    }

    [Fact]
    public void Task6_CalculatesExpressionCorrectly()
    {
        // (1^2 + 4) / (0^2 + 2*0 + 5) + 1 = 5 / 5 + 1 = 2
        Console.SetIn(new StringReader("0\n1"));

        double result = Program.Task6();

        Assert.Equal(2.0, result);
    }
}