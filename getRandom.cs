/* Provides random ints used in the
 * shuffle() method.  Random() was not 
 * producing random numbers. 
 * Code from: http://stackoverflow.com/questions/7251714/c-sharp-random-numbers-arent-being-random
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;

namespace ETSInterview_ohara
{
    class getRandom
    {
        private static int seed = Environment.TickCount;

        private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>
            (() => new Random(Interlocked.Increment(ref seed)));

        public static Random GetThreadRandom()
        {
            return randomWrapper.Value;
        }

    }
}
