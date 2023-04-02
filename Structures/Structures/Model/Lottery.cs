

using System.Collections;

namespace Structures.Model
{
    internal static class Lottery
    {
        public static HashSet<int> raffleAll = new HashSet<int>();
        public static int Number;

        public static List<int> Emit(int number, int N)
        {
            Number = number;
            raffleAll.Clear();

            Random rnd = new Random();
            while (raffleAll.Count != N)
            {
                raffleAll.Add(rnd.Next(1, number));
            }
            List<int> raff = new List<int>();   
            raff.AddRange(raffleAll);
            return raff;
        }
    }
}
