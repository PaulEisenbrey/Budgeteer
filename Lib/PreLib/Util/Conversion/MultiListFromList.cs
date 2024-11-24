using Utilities.ArgumentEvaluation;
using Utilities.Extension;

namespace Utilities.Conversion;

public static class MultiListFromList
{
    private static List<CeilingAndSplitCount> splitData = new();

    static MultiListFromList()
    {
        Initialize();
    }

    public static IEnumerable<IEnumerable<T>> Execute<T>(IEnumerable<T> list, ICollection<CeilingAndSplitCount>? splitList = null)
    {
        EvaluateArgument.Execute(list, fn => 1 > list.Count(), "Cannot split an empty list");

        splitList = splitList ?? splitData;
        return list.Split(splitList.FirstOrDefault(x => x.Ceiling > list.Count())?.SplitCount ?? 1);
    }

    private static void Initialize()
    {
        splitData.Add(new CeilingAndSplitCount { Ceiling = 1, SplitCount = 1 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 200, SplitCount = 2 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 300, SplitCount = 3 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 400, SplitCount = 4 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 500, SplitCount = 5 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 600, SplitCount = 6 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 700, SplitCount = 7 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 800, SplitCount = 8 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 900, SplitCount = 9 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 1_000, SplitCount = 10 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 50_000, SplitCount = 100 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 500_000, SplitCount = 200 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 1_000_000, SplitCount = 400 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 2_000_000, SplitCount = 800 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 4_000_000, SplitCount = 1_600 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 8_000_000, SplitCount = 3_200 });
        splitData.Add(new CeilingAndSplitCount { Ceiling = 16_000_000, SplitCount = 6_400 });  // more than this, you should make your own
        splitData.Add(new CeilingAndSplitCount { Ceiling = int.MaxValue, SplitCount = 200_000 }); // 2_147_483_647 -> yields 10K lists
    }

    public class CeilingAndSplitCount
    {
        public int Ceiling { get; set; }
        public int SplitCount { get; set; }
    }
}
