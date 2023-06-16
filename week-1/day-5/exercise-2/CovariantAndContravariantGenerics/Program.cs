using System;

public interface IProcessor<in TInput, out TResult>
{
    TResult Process(TInput input);
}

public class StringToIntProcessor : IProcessor<string, int>
{
    public int Process(string input)
    {
        return input.Length;
    }
}

public class DoubleToStringProcessor : IProcessor<double, string>
{
    public string Process(double input)
    {
        return input.ToString();
    }
}

public class Program
{
    static void Main()
    {
        IProcessor<string, object> stringProcessor = new StringToIntProcessor();
        string inputString = "Hello, World!";
        object result = stringProcessor.Process(inputString);
        Console.WriteLine($"Input: {inputString}");
        Console.WriteLine($"Output: {result}");

        Console.WriteLine();

        IProcessor<object, string> doubleProcessor = new DoubleToStringProcessor();
        double inputDouble = 3.14159;
        string output = doubleProcessor.Process(inputDouble);
        Console.WriteLine($"Input: {inputDouble}");
        Console.WriteLine($"Output: {output}");
    }
}
