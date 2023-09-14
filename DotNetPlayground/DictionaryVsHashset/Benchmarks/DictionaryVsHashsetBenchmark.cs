using BenchmarkDotNet.Attributes;

namespace DictionaryVsHashset.Benchmarks
{
    [Config(typeof(Config))]
    [MemoryDiagnoser]
    public sealed class DictionaryVsHashsetBenchmark
    {
        private readonly Dictionary<long, bool> _numberDictionary = new();
        private readonly List<long> _numberList = new();
        private readonly HashSet<long> _numberHashset = new();

        private readonly Dictionary<long, TestClass> _objectDictionary = new();
        private readonly List<TestClass> _objectList= new();
        private readonly HashSet<TestClass> _objectHashset= new();

        public DictionaryVsHashsetBenchmark()
        {
            SetUpDictionaryAndHashset();
            SetUpDictionaryAndHashsetObjects();
        }

        private void SetUpDictionaryAndHashset()
        {
            for (long i = 0; i < 10_000_000; ++i)
            {
                _numberDictionary.Add(i, true);
                _numberList.Add(i);

                long randomKey = Random.Shared.NextInt64(1_000_000);
                _numberHashset.Add(randomKey);
            }
        }

        private void SetUpDictionaryAndHashsetObjects()
        {
            for (long i = 0; i < 10_000_000; ++i)
            {
                TestClass testClass = new(i, "Random name", "Random address");

                _objectDictionary.Add(i, testClass);
                _objectList.Add(testClass);

                _objectHashset.Add(testClass);
            }
        }

        [Benchmark]
        public void TestNumberDictionary()
        {
            foreach (long key in _numberHashset)
            {
                _numberDictionary.ContainsKey(key);
            }
        }

        [Benchmark]
        public void TestNumberListToHashsetConversion()
        {
            HashSet<long> listToNumberHashset = _numberList.ToHashSet();
            foreach (long key in _numberHashset)
            {
                listToNumberHashset.Contains(key);
            }
        }

        [Benchmark]
        public void TestObjectDictionary()
        {
            foreach (long key in _numberHashset)
            {
                _numberDictionary.ContainsKey(key);
            }
        }

        [Benchmark]
        public void TestObjectListToHashsetConversion()
        {
            HashSet<TestClass> listToObjectHashset = _objectList.ToHashSet();
            foreach (TestClass key in _objectHashset)
            {
                listToObjectHashset.Contains(key);
            }
        }

        [Benchmark]
        public void TestObjectHashset()
        {
            foreach (TestClass key in _objectList)
            {
                _objectHashset.Contains(key);
            }
        }

        [Benchmark]
        public void TestNumberHashset()
        {
            foreach (long key in _numberList)
            {
                _numberHashset.Contains(key);
            }
        }

        private sealed record TestClass(long Id, string Name, string Address);
    }
}
