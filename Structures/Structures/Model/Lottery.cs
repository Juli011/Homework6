using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Model
{
    internal static class Lottery
    {
        public static List<int> raffleAll = new List<int>();
        public static int Number;
        
        public static HashSet<int> Emit(int number, int N)
        {
            Number = number;
            raffleAll.Clear();
            Random rnd = new Random();  
            for(int i = 0; i < N; i++)
            {
                raffleAll.Add(rnd.Next(1, number));
            }
            return new HashSet<int>(raffleAll);
        }
    }
}
