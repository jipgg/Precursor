using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Precursor.Storage;
using Precursor.Collections;
namespace Precursor.Benchmarks.ValueListBenchmarks;

public class SomeClass();

[MemoryDiagnoser]
// [SimpleJob(RuntimeMoniker.NativeAot10_0)]
[SimpleJob(RuntimeMoniker.Net10_0)]
[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(nuint))]
[GenericTypeArguments(typeof(SomeClass))]
public class Add<T> where T : new() {
   [Params(8, 16, 64)]
   public int N;

   [Benchmark]
   public int List() {
      var list = new List<T>();
      for (int i = 0; i < N; ++i) list.Add(default!);
      return list.Count;
   }
   [Benchmark]
   public int ValueList() {
      var list = new ValueList<T>();
      for (int i = 0; i < N; ++i) list.Add(default!);
      return list.Count;
   }
   [Benchmark]
   public int ValueList8() {
      var list = new ValueList<T, SmallBuffer8<T>>();
      for (int i = 0; i < N; ++i) list.Add(default!);
      return list.Count;
   }
   // [Benchmark]
   // public int ValueList64() {
   //    var list = new ValueList<T, SmallBuffer64<T>>();
   //    for (int i = 0; i < N; ++i) list.Add(default!);
   //    return list.Count;
   // }
   [Benchmark]
   public int ListPresized() {
      var list = new List<T>(N);
      for (int i = 0; i < N; ++i) list.Add(default!);
      return list.Count;
   }

}
