
namespace Structures.Model
{
    internal static class StatOperations
    {

        public static HashSet<int> NeverAppeared(this List<List<int>> raffleAllSet)
        {
            HashSet<int> result = new HashSet<int>();
            List<int> raffleAll = new List<int>();
            for (int r = 0; r<raffleAllSet.Count; r++)
            {
                raffleAll.AddRange(raffleAllSet[r]);
            }
            for (int i = 1; i<Lottery.Number; i++)
            {
                if (!raffleAll.Contains(i))
                    result.Add(i);
            }
            return result;
        }
        public static HashSet<int> MostAppeared(this List<List<int>> raffleAllSet, int N)
        {
            Dictionary<int, int> appeared = new Dictionary<int, int>();
            List<int> raffleAll = new List<int>();
            for (int r = 0; r<raffleAllSet.Count; r++)
            {
                raffleAll.AddRange(raffleAllSet[r]);
            }

            int count = 0;
            for (int i = 0; i<raffleAll.Count; i++)
            {
                for (int a = 0; a<raffleAll.Count; a++)
                {
                    if (raffleAll[i]== raffleAll[a]) count++;
                }
                if (!appeared.ContainsKey(raffleAll[i]))
                    appeared.Add(raffleAll[i], count);
            }


            List<int> result = new List<int>(N);
            appeared.OrderByDescending(x => x.Value);
            foreach (var i in appeared)
            {

                result.Add(i.Key);
            }

            HashSet<int> res = new HashSet<int>();
            int b = 0;
            while (res.Count != N)
            { res.Add(result[b]); b++; }

            return res;
        }
    }
}
