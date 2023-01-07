// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

var summary = BenchmarkRunner.Run<ConcatenationStrings>();
Console.ReadLine();

[MemoryDiagnoser]
public class ConcatenationStrings
{
    [Benchmark]
    public string ArithmeticConcatenationString()
    {
        var result = string.Empty;

        for (int i = 0; i < 1000; i++)
        {
            result += i.ToString();
        }

        return result;
    }

    [Benchmark]
    public string StringBuilderConcatenationString()
    {
        var result = new StringBuilder();

        for (int i = 0; i < 1000; i++)
        {
            result.Append(i);
        }

        return result.ToString();
    }
}