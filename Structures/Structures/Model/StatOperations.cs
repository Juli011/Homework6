using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Model
{
    internal static class StatOperations
    {

        public static HashSet<int> NeverAppeared(HashSet<int> raffle)
        {
            HashSet<int> result = new HashSet<int>();
            for (int i = 1; i<Lottery.Number; i++)
            {
                if (!raffle.Contains(i))
                    result.Add(i);
            }
            return result;
        }
        public static HashSet<int> MostAppeared(List<int> raffleAll, int N)
        {
            Dictionary<int, int> appeared = new Dictionary<int, int>();
            for (int i = 0; i<raffleAll.Count; i++)
            {
                int count = 0;
                for (int a = 0; a<raffleAll.Count; a++)
                {
                    if (raffleAll[i]== raffleAll[a]) count++;
                }
                if (!appeared.ContainsKey(raffleAll[i]))
                appeared.Add(raffleAll[i], count);
            }
            List<int> result = new List<int>(N);
            appeared.OrderByDescending(x => x.Value);
            foreach(var i in appeared)
            {
                
                result.Add(i.Key);
            }
            
            HashSet<int> res = new HashSet<int>();
            int b = 0;
            while(res.Count != N)
            { res.Add(result[b]); b++; }
            
            return res;
        }
    }
}
