using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsWPF;
using System.Globalization;
using System.Text;
using System.Security.Cryptography;
using System.Buffers;
using System.Runtime.InteropServices;
// using System.Collections.Frozen;
// using System.Collections.Immutable;

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
// dotnet run -c Release -f net6.0 --filter "*"
var config = DefaultConfig.Instance
    .AddJob(Job.Default.WithId(".NET 6").WithRuntime(CoreRuntime.Core60).AsBaseline())
    .AddJob(Job.Default.WithId(".NET 8 w/o PGO").WithRuntime(CoreRuntime.Core80).WithEnvironmentVariable("DOTNET_TieredPGO", "0"))
    .AddJob(Job.Default.WithId(".NET 8").WithRuntime(CoreRuntime.Core80));


BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);
// [MemoryDiagnoser(displayGenColumns: false)]
[HideColumns("Error", "StdDev", "Median", "RatioSD")]
public class Tests
{
//     // dotnet run -c Release -f net6.0 --filter "*" --runtimes net6.0 net8.0

//     // Arrange stringbuilder
//     private readonly StringBuilder _sb = new StringBuilder("http://server\\this\\is\\a\\test\\of\\needing\\to\\normalize\\directory\\separators\\");
//     // arrange datetime
//     private readonly DayOfWeek _dow = DayOfWeek.Saturday;
//     // Arrange Numeros
//     private const string Format = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";
//     private readonly string _s = new DateTime(1955, 11, 5, 6, 0, 0, DateTimeKind.Utc).ToString(Format, CultureInfo.InvariantCulture);

//     // arrange hex
//     private string _hex;
// // arrange Stringbuilder
//         private readonly StringBuilder _sbdos = new StringBuilder()
//         .Append("Shall I compare thee to a summer's day? ")
//         .Append("Thou art more lovely and more temperate: ")
//         .Append("Rough winds do shake the darling buds of May, ")
//         .Append("And summer's lease hath all too short a date; ")
//         .Append("Sometime too hot the eye of heaven shines, ")
//         .Append("And often is his gold complexion dimm'd; ")
//         .Append("And every fair from fair sometime declines, ")
//         .Append("By chance or nature's changing course untrimm'd; ")
//         .Append("But thy eternal summer shall not fade, ")
//         .Append("Nor lose possession of that fair thou ow'st; ")
//         .Append("Nor shall death brag thou wander'st in his shade, ")
//         .Append("When in eternal lines to time thou grow'st: ")
//         .Append("So long as men can breathe or eyes can see, ")
//         .Append("So long lives this, and this gives life to thee.");
//         private readonly StringBuilder _sbAppend = new();

// // arrange spans
//     private readonly Memory<char> _array = Enumerable.Repeat('a', 1000).ToArray();
// // arrange froz collections
//     private const int Items = 10_000;

//     private static readonly Dictionary<int, int> s_d = new Dictionary<int, int>(Enumerable.Range(0, Items).ToDictionary(x => x, x => x));
//     private static readonly ImmutableDictionary<int, int> s_id = ImmutableDictionary.CreateRange(Enumerable.Range(0, Items).ToDictionary(x => x, x => x));
//     private static readonly FrozenDictionary<int, int> s_fd = FrozenDictionary.ToFrozenDictionary(Enumerable.Range(0, Items).ToDictionary(x => x, x => x));

//     // Enums
//     [Benchmark] public bool EnumIsDefined() => Enum.IsDefined(_dow);
//     [Benchmark] public string EnumGetName() => Enum.GetName(_dow);
//     [Benchmark] public string[] EnumGetNames() => Enum.GetNames<DayOfWeek>();
//     [Benchmark] public DayOfWeek[] EnumGetValues() => Enum.GetValues<DayOfWeek>();
//     // No disponible en 6
//     // [Benchmark] public Array GetUnderlyingValues() => Enum.GetValuesAsUnderlyingType<DayOfWeek>();
//     [Benchmark] public string EnumToString() => _dow.ToString();
//     [Benchmark] public bool EnumTryParse() => Enum.TryParse<DayOfWeek>("Saturday", out _);

// // Numero
//     [Benchmark]
//     [Arguments(12)]
//     [Arguments(123)]
//     [Arguments(1_234_567_890)]
//     public string NumeroInt32ToString(int i) => i.ToString();

//     // datetime
//     [Benchmark]
//     public void DateTimeParseExact() => DateTimeOffset.ParseExact(_s, Format, CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite | DateTimeStyles.AssumeUniversal);
// // Arrange Hexa
//     [Params(4, 16, 128)]
//     public int Length { get; set; }

//     [GlobalSetup]
//     public void HexaSetup() => _hex = Convert.ToHexString(RandomNumberGenerator.GetBytes(Length));

//     [Benchmark]
//     public byte[] HexaConvertFromHex() => Convert.FromHexString(_hex);
//     // Stringbuilder
//         [Benchmark]
//     public void StringBuilderReplaceBigger()
//     {
//         _sb.Replace("summer", "winter");
//         _sb.Replace("winter", "summer");
//     }
//   // Stringbuilder Append
//     [Benchmark]
//     public void StringBuilderAppend()
//     {
//         _sbAppend.Clear();
//         _sbAppend.Append("This is a test of appending a string to StringBuilder");

//     }
//     // StringBuilder Replace
//     [Benchmark]
//     public void StringBuilderReplace()
//     {
//         _sb.Replace('\\', '/');
//         _sb.Replace('/', '\\');
//     }
// //Spans

//     [Benchmark]
//     public int linqCount() => Count(MemoryMarshal.ToEnumerable<char>(_array));

//     [Benchmark]
//     public int CountLINQ() => Enumerable.Count(MemoryMarshal.ToEnumerable<char>(_array));

//     private static int Count<T>(IEnumerable<T> source)
//     {
//         int count = 0;
//         foreach (T item in source) count++;
//         return count;
//     }

//     private sealed class WrapperMemoryManager<T>(Memory<T> memory) : MemoryManager<T>
//     {
//         public override Span<T> GetSpan() => memory.Span;
//         public override MemoryHandle Pin(int elementIndex = 0) => throw new NotSupportedException();
//         public override void Unpin() => throw new NotSupportedException();
//         protected override void Dispose(bool disposing) { }
//     }




// FrozenCollections // dotnet run -c Release -f net8.0 --filter "*"

    // [Benchmark]
    // public int FrozenCollectionsDictionaryGets()
    // {
    //     int sum = 0;
    //     for (int i = 0; i < Items; i++)
    //     {
    //         sum += s_d[i];
    //     }
    //     return sum;
    // }

    // [Benchmark]
    // public int FrozenCollectionsImmutableDictionaryGets()
    // {
    //     int sum = 0;
    //     for (int i = 0; i < Items; i++)
    //     {
    //         sum += s_id[i];
    //     }
    //     return sum;
    // }

    // [Benchmark(Baseline = true)]
    // public int FrozenCollectionsFrozenDictionaryGets()
    // {
    //     int sum = 0;
    //     for (int i = 0; i < Items; i++)
    //     {
    //         sum += s_fd[i];
    //     }
    //     return sum;
    // }

// CON CONFIG
    // Randoms
    private static readonly Random s_rand = new();

    [Benchmark]
    public int RandomNextMax() => s_rand.Next(12345);

// enumerators
    private readonly IEnumerable<int> _list = new List<int>();
    private readonly IEnumerable<int> _queue = new Queue<int>();
    private readonly IEnumerable<int> _hashSet = new HashSet<int>();
    private readonly IEnumerable<KeyValuePair<int, int>> _dictionary = new Dictionary<int, int>();
    private readonly IEnumerable<KeyValuePair<int, int>> _sortedDictionary = new SortedDictionary<int, int>();
    private readonly IEnumerable<KeyValuePair<int, int>> _sortedList = new SortedList<int, int>();

    [Benchmark] public IEnumerator<int> EnumeratorGetList() => _list.GetEnumerator();
    [Benchmark] public IEnumerator<int> EnumeratorGetQueue() => _queue.GetEnumerator();
    [Benchmark] public IEnumerator<int> EnumeratorGetHashSet() => _hashSet.GetEnumerator();
    [Benchmark] public IEnumerator<KeyValuePair<int, int>> EnumeratorGetDictionary() => _dictionary.GetEnumerator();
    [Benchmark] public IEnumerator<KeyValuePair<int, int>> EnumeratorGetSortedDictionary() => _sortedDictionary.GetEnumerator();
    [Benchmark] public IEnumerator<KeyValuePair<int, int>> EnumeratorGetSortedList() => _sortedList.GetEnumerator();

}











