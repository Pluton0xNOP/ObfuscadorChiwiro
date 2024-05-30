using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chiwiro.Utilidades
{
    internal class Randoms
    {

        private static Random random = new Random();

        public static string RandomString()
        {
            const string chars = "أبتثجحخدذرزسشصضطظعغفقكلمنهويأبتثجحخدذرزسشصضطظعغفقكلمنهويأبتثجحخدذرزسشصضطظعغفقكلمنهويأبتثجحخدذرزسشصضطظعغفقكلمنهوي";
            return new string(Enumerable.Repeat(chars, 100)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static int RandomInt()
        {
            return random.Next(0, 99999999);
        }

    }
}
