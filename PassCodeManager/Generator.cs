using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassCodeManager
{
    public class Generator
    {
        public static void Main(string[] args)
        {

        }

        private void GeneratePasscodes()
        {
            int length = 6;
            int repetitions = 2;
            int[] passcode = new int[length];


            for (int l = 0;  l < length;  l++)
            {
                for (int d = 0; d < 9; d++)
                {
                    for (int r = 0; r < repetitions; r++)
                    {
                        passcode[l] = d;
                    }
                }
            }

        }
    }
}
