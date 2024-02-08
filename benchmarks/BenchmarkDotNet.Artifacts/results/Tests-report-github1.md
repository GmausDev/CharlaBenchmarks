```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.3007/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-GTMSAC : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-QFQERJ : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2


```
| Method                     | Runtime  | Length | i          | Mean         | Ratio | 
|--------------------------- |--------- |------- |----------- |-------------:|------:|-
| **NumeroInt32ToString**        | **.NET 6.0** | **4**      | **12**         |     **9.011 ns** |  **1.00** | 
| NumeroInt32ToString        | .NET 8.0 | 4      | 12         |     2.880 ns |  0.33 | 
|                            |          |        |            |              |       | 
| **NumeroInt32ToString**        | **.NET 6.0** | **4**      | **123**        |     **8.413 ns** |  **1.00** | 
| NumeroInt32ToString        | .NET 8.0 | 4      | 123        |     2.610 ns |  0.31 | 
|                            |          |        |            |              |       | 
| **NumeroInt32ToString**        | **.NET 6.0** | **4**      | **1234567890** |    **14.507 ns** |  **1.00** | 
| NumeroInt32ToString        | .NET 8.0 | 4      | 1234567890 |    13.168 ns |  0.91 | 
|                            |          |        |            |              |       | 
| **EnumIsDefined**              | **.NET 6.0** | **4**      | **?**          |    **16.967 ns** |  **1.00** | 
| EnumIsDefined              | .NET 8.0 | 4      | ?          |     2.902 ns |  0.17 | 
|                            |          |        |            |              |       | 
| EnumGetName                | .NET 6.0 | 4      | ?          |    15.369 ns |  1.00 | 
| EnumGetName                | .NET 8.0 | 4      | ?          |     2.442 ns |  0.16 | 
|                            |          |        |            |              |       | 
| EnumGetNames               | .NET 6.0 | 4      | ?          |    16.033 ns |  1.00 | 
| EnumGetNames               | .NET 8.0 | 4      | ?          |    17.781 ns |  1.11 | 
|                            |          |        |            |              |       | 
| EnumGetValues              | .NET 6.0 | 4      | ?          |   385.798 ns |  1.00 | 
| EnumGetValues              | .NET 8.0 | 4      | ?          |    33.361 ns |  0.09 | 
|                            |          |        |            |              |       | 
| EnumToString               | .NET 6.0 | 4      | ?          |    13.670 ns |  1.00 | 
| EnumToString               | .NET 8.0 | 4      | ?          |    10.657 ns |  0.78 | 
|                            |          |        |            |              |       | 
| EnumTryParse               | .NET 6.0 | 4      | ?          |    40.183 ns |  1.00 | 
| EnumTryParse               | .NET 8.0 | 4      | ?          |    25.406 ns |  0.63 | 
|                            |          |        |            |              |       | 
| DateTimeParseExact         | .NET 6.0 | 4      | ?          |   827.452 ns |  1.00 | 
| DateTimeParseExact         | .NET 8.0 | 4      | ?          |   231.133 ns |  0.28 | 
|                            |          |        |            |              |       | 
| HexaConvertFromHex         | .NET 6.0 | 4      | ?          |    11.333 ns |  1.00 | 
| HexaConvertFromHex         | .NET 8.0 | 4      | ?          |    13.833 ns |  1.23 | 
|                            |          |        |            |              |       | 
| StringBuilderReplaceBigger | .NET 6.0 | 4      | ?          |   400.853 ns |  1.00 | 
| StringBuilderReplaceBigger | .NET 8.0 | 4      | ?          |    38.806 ns |  0.10 | 
|                            |          |        |            |              |       | 
| StringBuilderAppend        | .NET 6.0 | 4      | ?          |     8.864 ns |  1.00 | 
| StringBuilderAppend        | .NET 8.0 | 4      | ?          |     2.508 ns |  0.34 | 
|                            |          |        |            |              |       | 
| StringBuilderReplace       | .NET 6.0 | 4      | ?          |    94.472 ns |  1.00 | 
| StringBuilderReplace       | .NET 8.0 | 4      | ?          |    25.664 ns |  0.27 | 
|                            |          |        |            |              |       | 
| linqCount                  | .NET 6.0 | 4      | ?          | 4,539.352 ns |  1.00 | 
| linqCount                  | .NET 8.0 | 4      | ?          |   701.382 ns |  0.16 | 
|                            |          |        |            |              |       | 
| CountLINQ                  | .NET 6.0 | 4      | ?          | 3,119.288 ns | 1.000 | 
| CountLINQ                  | .NET 8.0 | 4      | ?          |     8.239 ns | 0.003 | 
|                            |          |        |            |              |       | 
| **NumeroInt32ToString**        | **.NET 6.0** | **16**     | **12**         |     **8.622 ns** |  **1.00** | 
| NumeroInt32ToString        | .NET 8.0 | 16     | 12         |     4.413 ns |  0.52 | 
|                            |          |        |            |              |       | 
| **NumeroInt32ToString**        | **.NET 6.0** | **16**     | **123**        |    **14.767 ns** |  **1.00** | 
| NumeroInt32ToString        | .NET 8.0 | 16     | 123        |     3.180 ns |  0.22 | 
|                            |          |        |            |              |       | 
| **NumeroInt32ToString**        | **.NET 6.0** | **16**     | **1234567890** |    **20.701 ns** |  **1.00** | 
| NumeroInt32ToString        | .NET 8.0 | 16     | 1234567890 |    21.077 ns |  0.98 | 
|                            |          |        |            |              |       | 
| **EnumIsDefined**              | **.NET 6.0** | **16**     | **?**          |    **22.606 ns** |  **1.00** | 
| EnumIsDefined              | .NET 8.0 | 16     | ?          |     3.534 ns |  0.15 | 
|                            |          |        |            |              |       | 
| EnumGetName                | .NET 6.0 | 16     | ?          |    23.785 ns |  1.00 | 
| EnumGetName                | .NET 8.0 | 16     | ?          |     3.911 ns |  0.17 | 
|                            |          |        |            |              |       | 
| EnumGetNames               | .NET 6.0 | 16     | ?          |    29.382 ns |  1.00 | 
| EnumGetNames               | .NET 8.0 | 16     | ?          |    19.049 ns |  0.66 | 
|                            |          |        |            |              |       | 
| EnumGetValues              | .NET 6.0 | 16     | ?          |   700.791 ns |  1.00 | 
| EnumGetValues              | .NET 8.0 | 16     | ?          |    31.116 ns |  0.04 | 
|                            |          |        |            |              |       | 
| EnumToString               | .NET 6.0 | 16     | ?          |    25.619 ns |  1.00 | 
| EnumToString               | .NET 8.0 | 16     | ?          |    11.088 ns |  0.43 | 
|                            |          |        |            |              |       | 
| EnumTryParse               | .NET 6.0 | 16     | ?          |    65.967 ns |  1.00 | 
| EnumTryParse               | .NET 8.0 | 16     | ?          |    23.018 ns |  0.35 | 
|                            |          |        |            |              |       | 
| DateTimeParseExact         | .NET 6.0 | 16     | ?          | 1,268.319 ns |  1.00 | 
| DateTimeParseExact         | .NET 8.0 | 16     | ?          |   224.100 ns |  0.18 | 
|                            |          |        |            |              |       | 
| HexaConvertFromHex         | .NET 6.0 | 16     | ?          |    52.645 ns |  1.00 | 
| HexaConvertFromHex         | .NET 8.0 | 16     | ?          |    16.056 ns |  0.31 | 
|                            |          |        |            |              |       | 
| StringBuilderReplaceBigger | .NET 6.0 | 16     | ?          |   542.017 ns |  1.00 | 
| StringBuilderReplaceBigger | .NET 8.0 | 16     | ?          |    35.406 ns |  0.07 | 
|                            |          |        |            |              |       | 
| StringBuilderAppend        | .NET 6.0 | 16     | ?          |     9.102 ns |  1.00 | 
| StringBuilderAppend        | .NET 8.0 | 16     | ?          |     2.404 ns |  0.26 | 
|                            |          |        |            |              |       | 
| StringBuilderReplace       | .NET 6.0 | 16     | ?          |   201.241 ns |  1.00 | 
| StringBuilderReplace       | .NET 8.0 | 16     | ?          |    22.702 ns |  0.22 | 
|                            |          |        |            |              |       | 
| linqCount                  | .NET 6.0 | 16     | ?          | 8,876.620 ns |  1.00 | 
| linqCount                  | .NET 8.0 | 16     | ?          |   633.128 ns |  0.08 | 
|                            |          |        |            |              |       | 
| CountLINQ                  | .NET 6.0 | 16     | ?          | 7,291.042 ns | 1.000 | 
| CountLINQ                  | .NET 8.0 | 16     | ?          |     8.349 ns | 0.001 | 
|                            |          |        |            |              |       | 
| **NumeroInt32ToString**        | **.NET 6.0** | **128**    | **12**         |     **8.377 ns** |  **1.00** | 
| NumeroInt32ToString        | .NET 8.0 | 128    | 12         |     2.999 ns |  0.37 | 
|                            |          |        |            |              |       | 
| **NumeroInt32ToString**        | **.NET 6.0** | **128**    | **123**        |     **8.371 ns** |  **1.00** | 
| NumeroInt32ToString        | .NET 8.0 | 128    | 123        |     2.824 ns |  0.35 | 
|                            |          |        |            |              |       | 
| **NumeroInt32ToString**        | **.NET 6.0** | **128**    | **1234567890** |    **14.656 ns** |  **1.00** | 
| NumeroInt32ToString        | .NET 8.0 | 128    | 1234567890 |    11.629 ns |  0.77 | 
|                            |          |        |            |              |       | 
| **EnumIsDefined**              | **.NET 6.0** | **128**    | **?**          |    **15.719 ns** |  **1.00** | 
| EnumIsDefined              | .NET 8.0 | 128    | ?          |     2.262 ns |  0.14 | 
|                            |          |        |            |              |       | 
| EnumGetName                | .NET 6.0 | 128    | ?          |    17.186 ns |  1.00 | 
| EnumGetName                | .NET 8.0 | 128    | ?          |     2.143 ns |  0.13 | 
|                            |          |        |            |              |       | 
| EnumGetNames               | .NET 6.0 | 128    | ?          |    18.522 ns |  1.00 | 
| EnumGetNames               | .NET 8.0 | 128    | ?          |    15.726 ns |  0.88 | 
|                            |          |        |            |              |       | 
| EnumGetValues              | .NET 6.0 | 128    | ?          |   444.963 ns |  1.00 | 
| EnumGetValues              | .NET 8.0 | 128    | ?          |    29.557 ns |  0.07 | 
|                            |          |        |            |              |       | 
| EnumToString               | .NET 6.0 | 128    | ?          |    14.893 ns |  1.00 | 
| EnumToString               | .NET 8.0 | 128    | ?          |    10.043 ns |  0.67 | 
|                            |          |        |            |              |       | 
| EnumTryParse               | .NET 6.0 | 128    | ?          |    40.788 ns |  1.00 | 
| EnumTryParse               | .NET 8.0 | 128    | ?          |    23.199 ns |  0.57 | 
|                            |          |        |            |              |       | 
| DateTimeParseExact         | .NET 6.0 | 128    | ?          |   820.612 ns |  1.00 | 
| DateTimeParseExact         | .NET 8.0 | 128    | ?          |   209.238 ns |  0.25 | 
|                            |          |        |            |              |       | 
| HexaConvertFromHex         | .NET 6.0 | 128    | ?          |   178.412 ns |  1.00 | 
| HexaConvertFromHex         | .NET 8.0 | 128    | ?          |    43.737 ns |  0.25 | 
|                            |          |        |            |              |       | 
| StringBuilderReplaceBigger | .NET 6.0 | 128    | ?          |   392.802 ns |  1.00 | 
| StringBuilderReplaceBigger | .NET 8.0 | 128    | ?          |    35.207 ns |  0.09 | 
|                            |          |        |            |              |       | 
| StringBuilderAppend        | .NET 6.0 | 128    | ?          |     8.926 ns |  1.00 | 
| StringBuilderAppend        | .NET 8.0 | 128    | ?          |     2.375 ns |  0.26 | 
|                            |          |        |            |              |       | 
| StringBuilderReplace       | .NET 6.0 | 128    | ?          |    96.652 ns |  1.00 | 
| StringBuilderReplace       | .NET 8.0 | 128    | ?          |    24.357 ns |  0.25 | 
|                            |          |        |            |              |       | 
| linqCount                  | .NET 6.0 | 128    | ?          | 4,757.406 ns |  1.00 | 
| linqCount                  | .NET 8.0 | 128    | ?          |   652.758 ns |  0.14 | 
|                            |          |        |            |              |       | 
| CountLINQ                  | .NET 6.0 | 128    | ?          | 3,218.560 ns | 1.000 | 
| CountLINQ                  | .NET 8.0 | 128    | ?          |     8.956 ns | 0.003 | 
