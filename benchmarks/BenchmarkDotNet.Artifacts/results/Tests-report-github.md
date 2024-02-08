```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.3007/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]         : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  .NET 6         : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  .NET 8         : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  .NET 8 w/o PGO : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2


```
| Method                        | Job            | EnvironmentVariables | Runtime  | Mean       | Ratio | 
|------------------------------ |--------------- |--------------------- |--------- |-----------:|------:|-
| RandomNextMax                 | .NET 6         | Empty                | .NET 6.0 |  4.8249 ns |  1.00 | 
| RandomNextMax                 | .NET 8         | Empty                | .NET 8.0 |  0.5471 ns |  0.11 | 
| RandomNextMax                 | .NET 8 w/o PGO | DOTNET_TieredPGO=0   | .NET 8.0 |  1.6330 ns |  0.34 | 
|                               |                |                      |          |            |       | 
| EnumeratorGetList             | .NET 6         | Empty                | .NET 6.0 |  7.1036 ns |  1.00 | 
| EnumeratorGetList             | .NET 8         | Empty                | .NET 8.0 |  2.0680 ns |  0.29 | 
| EnumeratorGetList             | .NET 8 w/o PGO | DOTNET_TieredPGO=0   | .NET 8.0 |  2.2494 ns |  0.32 | 
|                               |                |                      |          |            |       | 
| EnumeratorGetQueue            | .NET 6         | Empty                | .NET 6.0 |  7.0760 ns |  1.00 | 
| EnumeratorGetQueue            | .NET 8         | Empty                | .NET 8.0 |  1.3186 ns |  0.19 | 
| EnumeratorGetQueue            | .NET 8 w/o PGO | DOTNET_TieredPGO=0   | .NET 8.0 |  2.5538 ns |  0.36 | 
|                               |                |                      |          |            |       | 
| EnumeratorGetHashSet          | .NET 6         | Empty                | .NET 6.0 |  6.8756 ns |  1.00 | 
| EnumeratorGetHashSet          | .NET 8         | Empty                | .NET 8.0 |  1.3525 ns |  0.20 | 
| EnumeratorGetHashSet          | .NET 8 w/o PGO | DOTNET_TieredPGO=0   | .NET 8.0 |  2.5061 ns |  0.39 | 
|                               |                |                      |          |            |       | 
| EnumeratorGetDictionary       | .NET 6         | Empty                | .NET 6.0 |  9.8867 ns |  1.00 | 
| EnumeratorGetDictionary       | .NET 8         | Empty                | .NET 8.0 |  1.7093 ns |  0.17 | 
| EnumeratorGetDictionary       | .NET 8 w/o PGO | DOTNET_TieredPGO=0   | .NET 8.0 |  2.4475 ns |  0.25 | 
|                               |                |                      |          |            |       | 
| EnumeratorGetSortedDictionary | .NET 6         | Empty                | .NET 6.0 | 25.7359 ns |  1.00 | 
| EnumeratorGetSortedDictionary | .NET 8         | Empty                | .NET 8.0 |  3.5990 ns |  0.15 | 
| EnumeratorGetSortedDictionary | .NET 8 w/o PGO | DOTNET_TieredPGO=0   | .NET 8.0 |  5.4946 ns |  0.21 | 
|                               |                |                      |          |            |       | 
| EnumeratorGetSortedList       | .NET 6         | Empty                | .NET 6.0 |  9.6988 ns |  1.00 | 
| EnumeratorGetSortedList       | .NET 8         | Empty                | .NET 8.0 |  2.3409 ns |  0.24 | 
| EnumeratorGetSortedList       | .NET 8 w/o PGO | DOTNET_TieredPGO=0   | .NET 8.0 |  5.1566 ns |  0.53 | 
