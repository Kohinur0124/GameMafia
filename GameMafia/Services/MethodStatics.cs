using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace GameMafia.Services
{
    public static class MethodStatics
    {
        static Random _rand = new Random();
        public static void Shuffle<T>(this IList<T> ts)
        {
            int n = ts.Count;
            while (n > 1)
            {
                n--;
                int k = _rand.Next(n + 1);
                T value = ts[k];
                ts[k] = ts[n];
                ts[n] = value;
            }
        }
    }
}
