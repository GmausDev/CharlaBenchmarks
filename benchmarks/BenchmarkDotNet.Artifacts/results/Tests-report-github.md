```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.3007/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2


```
| Method                        | Mean      | 
|------------------------------ |----------:|-
| RandomNextMax                 |  8.108 ns | 
| EnumeratorGetList             | 11.320 ns | 
| EnumeratorGetQueue            | 11.469 ns | 
| EnumeratorGetHashSet          | 11.260 ns | 
| EnumeratorGetDictionary       | 14.087 ns | 
| EnumeratorGetSortedDictionary | 42.137 ns | 
| EnumeratorGetSortedList       | 10.233 ns | 
