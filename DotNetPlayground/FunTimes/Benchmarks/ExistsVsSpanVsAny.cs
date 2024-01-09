using BenchmarkDotNet.Attributes;
using FunTimes.TaskVsValueTask;
using System.Runtime.InteropServices;

namespace FunTimes.Benchmarks;

[Config(typeof(FunTimes.Config))]
[MemoryDiagnoser]
public class ExistsVsSpanVsAny
{
	private const string searchString = "String to search";
    private const int numberToSearch = 4355;
    private const string nameToSearch = "Search person";

	private List<int> numberList100 = new();
	private List<int> numberList10000 = new();
	private List<int> numberList1000000 = new();
	private List<string> stringList100 = new();
	private List<string> stringList10000 = new();
	private List<string> stringList1000000 = new();
	private List<TestClass> objectList100 = new();
	private List<TestClass> objectList10000 = new();
	private List<TestClass> objectList1000000 = new();

    public ExistsVsSpanVsAny()
	{
		for (int i = 0; i < 1_000_000; i++)
		{
            if (i < 100) 
			{
                if (i == 99)
                {
                    stringList100.Add(searchString);
                    //objectList100.Add(new TestClass("Search person", "Test", 100));
                    //numberList100.Add(numberToSearch);
                }
                else
                {
                    //numberList100.Add(GetRandomNumber(numberToSearch));
                    stringList100.Add("test");
                    //objectList100.Add(new TestClass("Test", "Test", 100));
                }
            }

            if (i < 10_000)
            {
                if (i == 9999)
                {
                    stringList10000.Add(searchString);
                    //objectList10000.Add(new TestClass("Search person", "Test", 10));
                    //numberList10000.Add(numberToSearch);

                }
                else
                {
                    //numberList10000.Add(GetRandomNumber(numberToSearch));

                    stringList10000.Add("test");
                    //objectList10000.Add(new TestClass("Test", "Test", 100));
                }
            }

            if (i < 1_000_000)
            {   
                if (i == 999_999)
                {
                    //numberList1000000.Add(numberToSearch);
                    stringList1000000.Add(searchString);
                    //objectList1000000.Add(new TestClass("Search person", "Test", 10));
                }
                else
                {
                    //numberList1000000.Add(GetRandomNumber(numberToSearch));
                    stringList1000000.Add("test");
                    //objectList1000000.Add(new TestClass("Test", "Test", 100));
                }
            }
        }
	}

    private int GetRandomNumber(int exclusionNumber)
    {
        int randomNumber = Random.Shared.Next(1_000_00);
        while (exclusionNumber == randomNumber)
        {
            randomNumber = Random.Shared.Next(1_000_00);
        }

        return randomNumber;
    }

    private sealed record TestClass(string name, string address, int age);

    //   [Benchmark]
    //   public bool NumberList100ExistsItteration() => numberList100.Exists(number => number == numberToSearch);

    //   [Benchmark]
    //   public bool NumberList100AnyItteration() => numberList100.Any(number => number == numberToSearch);

    //   [Benchmark]
    //   public bool NumberList100SpanItteration()
    //   {
    //       Span<int> spanList = CollectionsMarshal.AsSpan(numberList100);

    //       for (int i = 0; i < spanList.Length; i++)
    //       {
    //           if (spanList[i] == numberToSearch)
    //           {
    //               return true;
    //           }
    //       }

    //       return false;
    //   }

    //   [Benchmark]
    //   public bool NumberList10000ExistsItteration() => numberList10000.Exists(number => number == numberToSearch);

    //   [Benchmark]
    //   public bool NumberList10000AnyItteration() => numberList10000.Any(number => number == numberToSearch);

    //   [Benchmark]
    //   public bool NumberList10000SpanItteration()
    //   {
    //       Span<int> spanList = CollectionsMarshal.AsSpan(numberList10000);

    //       for (int i = 0; i < spanList.Length; i++)
    //       {
    //           if (spanList[i] == numberToSearch)
    //           {
    //               return true;
    //           }
    //       }

    //       return false;
    //   }

    //   [Benchmark]
    //   public bool NumberList1000000ExistsItteration() => numberList1000000.Exists(number => number == numberToSearch);

    //   [Benchmark]
    //   public bool NumberList1000000AnyItteration() => numberList1000000.Any(number => number == numberToSearch);

    //   [Benchmark]
    //   public bool NumberList1000000SpanItteration()
    //   {
    //       Span<int> spanList = CollectionsMarshal.AsSpan(numberList1000000);

    //       for (int i = 0; i < spanList.Length; i++)
    //       {
    //           if (spanList[i] == numberToSearch)
    //           {
    //               return true;
    //           }
    //       }

    //       return false;
    //   }

    [Benchmark]
    public bool StringList100ExistsItteration() => stringList100.Exists(@string => @string == searchString);

    [Benchmark]
    public bool StringList100AnyItteration() => stringList100.Any(@string => @string == searchString);

    [Benchmark]
    public bool StringList100SpanItteration()
    {
        Span<string> spanList = CollectionsMarshal.AsSpan(stringList100);

        for (int i = 0; i < spanList.Length; i++)
        {
            if (spanList[i] == searchString)
            {
                return true;
            }
        }

        return false;
    }

    [Benchmark]
    public bool StringList10000ExistsItteration() => stringList10000.Exists(@string => @string == searchString);

    [Benchmark]
    public bool StringList10000AnyItteration() => stringList10000.Any(@string => @string == searchString);

    [Benchmark]
    public bool StringList10000SpanItteration()
    {
        Span<string> spanList = CollectionsMarshal.AsSpan(stringList10000);

        for (int i = 0; i < spanList.Length; i++)
        {
            if (spanList[i] == searchString)
            {
                return true;
            }
        }

        return false;
    }

    [Benchmark]
    public bool StringList1000000ExistsItteration() => stringList1000000.Exists(@string => @string == searchString);

    [Benchmark]
    public bool StringList1000000AnyItteration() => stringList1000000.Any(@string => @string == searchString);

    [Benchmark]
    public bool StringList1000000SpanItteration()
    {
        Span<string> spanList = CollectionsMarshal.AsSpan(stringList1000000);

        for (int i = 0; i < spanList.Length; i++)
        {
            if (spanList[i] == searchString)
            {
                return true;
            }
        }

        return false;
    }
}
